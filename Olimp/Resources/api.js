socket = 0; //Объявляем глобальное назание соединения
api_id = 0;

function Temps_Pause() { //Объект с параметрами
    this.t = 0; //время
    this.m = -1; //является ли покупатель мейкеров
}

function start(inter) { //функция запуска соединения

    if (socket.readyState == 3 || socket == 0) { //проверка, что соединения еще нет
        olimp_connect(inter); // запускаем скрипт и подключаемся
    }
}

function stop() { //Функция отключения
    if (socket.readyState == 1) { //проверяем, что есть подключение 
        socket.close(1000, 'Работа закончена'); //отключем соединение, отправив код отключения и причину
    }
}

function olimp_connect(inter) {//Функция запуска скрипта
    var api_url = 'wss://stream.binance.com:9443'; // URL адрес stream api для подключения

    update_value();
    temp_pause = new Temps_Pause(); // Создаем объект, для хранения даных
    interfece = inter;

    if (!interfece) //Снова :0 проверяем интерфейс, если старый
    { //В старом интерфейсе есть готовое название пары, достаем его
        let temp = $('li[class *= "pair-tab_selected"]').attr('data-label');
        temp = temp.toLowerCase(); //Делаем регист букв маленьким

        //если найдена нужная пара, редактируем название, что бы biance понял
        if (temp.localeCompare('ethusd') == 0) symbol = 'ethusdt';
        else if (temp.localeCompare('bitcoin') == 0) symbol = 'btcusdt';
        else if (temp.localeCompare('etcusd') == 0) symbol = 'etcusdt';
        else if (temp.localeCompare('dashusd') == 0) symbol = 'dashusdt';
        else if (temp.localeCompare('zecusd') == 0) symbol = 'zecusdt';
        else if (temp.localeCompare('xrpusd') == 0) symbol = 'xrpusdt';
        else return alert('Ошибка выбора пары!');
    }
    else { //если новый

        let temp = $('span[class *= "pair-assets-select-title"]')[0].innerText; //Достаем название пары
        //если найдена нужная пара, вставляем название, в зависимости от пары
        if (temp.localeCompare('Ethereum Classic') == 0) symbol = 'etcusdt';
        else if (temp.localeCompare('Ethereum') == 0) symbol = 'ethusdt';
        else if (temp.localeCompare('Bitcoin') == 0) symbol = 'btcusdt';
        else if (temp.localeCompare('Dash') == 0) symbol = 'dashusdt';
        else if (temp.localeCompare('Zcash') == 0) symbol = 'zecusdt';
        else if (temp.localeCompare('Ripple') == 0) symbol = 'xrpusdt';
        else return alert('Ошибка выбора пары!');
    }
    update('value');
    socket = new WebSocket(api_url + '/stream?streams=' + symbol + '@aggTrade'); //Создаем подключение
    socket.onopen = function (e) { web_open(e); }; //назначаем функцию, которая вызывается, когда соединение открыто
    socket.onmessage = function (event) { web_onmessage(event); }; //вызыввается, когда пришло сообщение по соединению
    socket.onclose = function (event) { web_onclose(event); }; //Вызывается, когда соединение закрыто
    socket.onerror = function (error) { web_onerror(error); }; //Вызывается, если появилась ошибка

}

function testing() {
    pog_log(this);
}

// web_socket
function web_open(e) { //Открыто соединение

    text_info('Соединение открыто', 'open');

    pog_log('[' + symbol + '] Соединение открыто'); //Пишем в консоль
    console.log('[' + symbol + '] Соединение открыто'); //Пишем в консоль
};

function web_onmessage(event) { //Сообщения
    var data = JSON.parse(event.data); //Достаем данные из сообщения
    data = data.data; //Уменьшаем количество писанины :) 

    //Определяем тип сообщения
    if (data.e.localeCompare('aggTrade') == 0) // если это данные о сделки
    {
        update_value();
        //В зависимости от интерфейса узнаем процент дохода
        if (interfece) percent = $('span[class *= "pair-assets-select-label"]')[0].innerText; // в старом
        else percent = $('li[class *= "pair-tab_selected"] .percent')[0].innerText; // в новом 
        percent = parseFloat(percent[0] + percent[1]); //отделяем знак %

        if (parseFloat(data.q) >= min_value) { //Проверяем, достаточно ли обхема данной сделки
            var balance = parseFloat($('span[class *= "sum header-row__balance-sum"]')[0].innerText.replace(/s+/g, '')); //берем информацию о балансе
            var money = parseFloat($('.input-currency__input')[0].value.replace(/s+/g, '')) //Берем информацию о ставке
            if (balance < min_money + money) { //Если денег меньше, чем ставка + минимальная сумма на счету
                pog_log('Достигнут лимит средств.'); //Останавливаем программу
                stop();
                return true;
            }

            if (percent < min_procent) { //Проверяем процент дохода, если слишком низок

                update('price', data.p);
                update('size', data.q);
                return pog_log('Процент прибыли слишком низок!'); // Выходим из функции, с сообщением
            }
            if (temp_pause.t > 0) { //Если сделки уже были
                let temp = data.E - temp_pause.t; // вычисляем прошедшее время между поставленной сделкой

                if (time_pause > 0 && temp_pause.m != data.m && time_pause * 1000 > temp) //Если в настройках установлена пауза, и ставки противоположны, проверяем, прошло ли требуеммое время (в миллисекундах)
                { //если не прошло
                    update('price', data.p);
                    update('size', data.q);
                    return pog_log('Противоположные ставки слишком близки.'); /// Выходим из функции, с сообщением
                }

                if (pause > 0 && pause * 1000 > temp) //Если в настройках установлена пауза для любого, проверяем, прошло ли требуеммое время (в миллисекундах)
                {//если не прошло
                    update('price', data.p);
                    update('size', data.q);
                    return pog_log('Ставки слишком близки.');/// Выходим из функции, с сообщением
                }
            }
            //Если все условия пройдены, проверяем куда нажимать
            if (data.m) {
                click_button(false); //нажимаем вверх
            }
            else {
                click_button(true); // нажимаем вниз
            }
            temp_pause.t = data.E; //Записываем время сделки
            temp_pause.m = data.m; // записываем куда нажали
            pog_log(data.q, data.m); //выводим в консоль сообщение об объеме и куда нажали
        }
        update('price', data.p);
        update('size', data.q); //обновляем данные


    }
    else if (data.e.localeCompare('depthUpdate') == 0) { //Если данные пришли с информацией об ордерах

        return true; //Временная загушка
    }
    else pog_log('Не определен тип получаемых данных:' + data); //Если данные не определенны, выводим их
};

function web_onclose(event) { //вызывается при закрытии
    if (event.wasClean) { //если нет ошибок
        pog_log('[' + symbol + '] Соединение закрыто чисто, код ' + event.code + ' причина ' + event.reason); //пишем
        console.log('[' + symbol + '] Соединение закрыто чисто, код ' + event.code + ' причина ' + event.reason); //пишем
    } else { //если есть
        pog_log('[' + symbol + '] Соединение прервано с кодом ' + event.code); //пишем
        console.log('[' + symbol + '] Соединение прервано с кодом ' + event.code); //пишем
    }

    text_info('Соединение закрыто', 'close');
};

function web_onerror(error) { //если ошибка
    pog_log('error [' + symbol + '] ' + error.message); //пишем ошибку
}
//-----------------------------------


function click_button(type) {//функция нажатия кнопки

    if (type) {
        $('[class *= "buttons__button_up"]').filter(':button').click(); //ищем и нажимаем кнопку вверх
    }
    else {
        $('[class *= "buttons__button_down"]').filter(':button').click(); //ищем и нажимаем кнопку вниз
    }
}

function update(type, param1 = 0) { //функция обновления 
    if (type.localeCompare('value') == 0)
        update_to(type, symbol);
    else update_to(type, param1);
}
function add_update() {
    $('div[class *="pair-assets-list__row"]').attr('onclick', 'setTimeout(update,300);');
}