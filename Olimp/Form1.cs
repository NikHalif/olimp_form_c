using EO.Internal;
using EO.WebBrowser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using QuickType;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Olimp
{
    public partial class Form1 : Form
    {
        bool web_interface;
        private bool connect = false;
        delegate void del_bool(bool bo);
        delegate void del_float(float bo);
        delegate void del_decimal(decimal bo);
        delegate void del_str(string bo);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webControl1.WebView.Url = "https://olymptrade.com";
            webView1.RegisterJSExtensionFunction("update_to", new JSExtInvokeHandler(update_file));
            webView1.RegisterJSExtensionFunction("price_sym", new JSExtInvokeHandler(price_sum));
            webView1.RegisterJSExtensionFunction("pog_log", new JSExtInvokeHandler(Consel_log));
            webView1.RegisterJSExtensionFunction("update_value", new JSExtInvokeHandler(up_prog));
            webView1.RegisterJSExtensionFunction("text_info", new JSExtInvokeHandler(InfoText));
            ScriptEngine engine = Python.CreateEngine();
        }

        void up_prog(object sender, JSExtInvokeArgs e)
        {
            webView1.EvalScript(@"
                time_pause = " + timer_pp_pay.Value + ";" +
                "min_value = " + size_pay.Value +";" +
                "min_money = " + min_money.Value +";" +
                "pause = " + timer_pay.Value +";" +
                "min_procent = " + procent_money.Value +";");
        }
        void InfoText(object sender, JSExtInvokeArgs e)
        {
            text_info.Invoke(new del_str((s) => text_info.Text = s), e.Arguments[0] as string);
            switch (e.Arguments[1])
            {
                case "close":
                    {
                        button_start.Invoke(new del_bool((s) => button_start.Enabled = s), true);
                        button_start.Invoke(new del_str((s) => button_start.Text = s), "Запустить");
                        connect = false;
                        break;
                    }
                case "open":
                    {
                        button_start.Invoke(new del_bool((s) => button_start.Enabled = s), true);
                        button_start.Invoke(new del_str((s) => button_start.Text = s), "Отключить");
                        connect = true;
                        /*var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.binance.com/api/v1/depth?symbol=BNBBTC&limit=10");

                        httpWebRequest.ContentType = "text/json";
                        httpWebRequest.Method = "GET";//Можно GET
                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            //ответ от сервера
                            var result = streamReader.ReadToEnd();

                            //Сериализация
                            Book text_res = JsonConvert.DeserializeObject<Book>(result);
                            for (int i = 0; i < text_res.Bids.Length; i++)
                            {
                                log_text.Items.Add("Bids: " + text_res.Bids[i] + "  Asks: " + text_res.Asks[i]);
                            }
                        }*/
                        break;
                    }
            }
        }
        void price_sum(object sender, JSExtInvokeArgs e)
        {
            webView1.EvalScript("aler('price')");
        }
        void Consel_log(object sender, JSExtInvokeArgs e)
        {
            log_text.Items.Add(e.Arguments[0] as string);
        }
        void update_file(object sender, JSExtInvokeArgs e)
        {
            string type = e.Arguments[0] as string;
            switch (type)
            {
                case "value":
                    {
                        var symbol = e.Arguments[1] as string;
                        switch (symbol)
                        {
                            case "etcusdt": //Ethereum Classic
                                {
                                    update_inter(70, 180, 3, 1);
                                    break;
                                }
                            case "ethusdt": //Ethereum
                                {
                                    update_inter(70, 25, 3, 1);
                                    break;
                                }
                            case "btcusdt": //Bitcoin
                                {
                                    update_inter(70, Convert.ToDecimal("4.5"), 3, 0);
                                    break;
                                }
                            case "dashusdt": //Dash
                                {
                                    update_inter(70, 100, 3, 0);
                                    break;
                                }
                            case "zecusdt": //Zcash
                                {
                                    update_inter(70, 150, 3, 0);
                                    break;
                                }
                            case "xrpusdt": //Ripple
                                {
                                    update_inter(70, 25000, 3, 2);
                                    break;
                                }
                            default: break;
                        }
                        break;
                    }
                case "price":
                    {
                        cena.Invoke(new del_str((s) => cena.Text = s), e.Arguments[1] as string);
                        break;
                    }
                case "size":
                    {
                        value_pay.Invoke(new del_str((s) => value_pay.Text = s), e.Arguments[1] as string);
                        break;
                    }
                default: break;
            }
            
        }

        void update_inter(decimal min_proc, decimal min_value, decimal time_pp, decimal time)
        {
            procent_money.Invoke(new del_decimal((s) => procent_money.Value = s), min_proc);
            size_pay.Invoke(new del_decimal((s) => size_pay.Value = s), min_value);
            timer_pp_pay.Invoke(new del_decimal((s) => timer_pp_pay.Value = s), time_pp);
            timer_pay.Invoke(new del_decimal((s) => timer_pay.Value = s), time);
        }

        private void Inject_button_Click(object sender, EventArgs e)
        {
           string Code = @"let script = document.createElement('script'); 
           script.setAttribute('type', 'text/javascript');
           script.setAttribute('src', 'https://code.jquery.com/jquery-3.4.1.js');
           document.getElementsByTagName('head')[0].appendChild(script); ";
            _ = webView1.EvalScript(Code);
            
            Code = ""+Properties.Resources.api.Clone();
            _ = webView1.EvalScript(Code);

            TimerCallback tm = new TimerCallback(IsInter);
            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 600, 0);
        }

        public void IsInter(object obj)
        {
            int temp_int_1 = (int)webView1.EvalScript("$('span[class *= \"pair-assets-select-title\"]').length;");
            int temp_int_2 = (int)webView1.EvalScript("$('li[class *=\"pair-tab_selected\"]>.inner > .title').length;");
            if (temp_int_1 > 0)
            {
                inject_button.Invoke(new del_bool((s) => inject_button.Enabled = s), false);
                setting_panel.Invoke(new del_bool((s) => setting_panel.Enabled = s), true);
                webView1.EvalScript("$('.settings-button').attr('onclick','setTimeout(add_update,300);');");
                web_interface = true;
                MessageBox.Show("Успешно подключено к новому интерфейсу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (temp_int_2 > 0)
            {
                inject_button.Invoke(new del_bool((s) => inject_button.Enabled = s), false);
                setting_panel.Invoke(new del_bool((s) => setting_panel.Enabled = s), true);
                webView1.EvalScript("$('li[class *=\"pair - tab\"]').attr('onclick','setTimeout(() => update(\"value\"),300);');");
                web_interface = false;
                MessageBox.Show("Успешно подключено к старому интерфейсу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Не найдены элементы интерфейса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Open_debag_Click(object sender, EventArgs e)
        {
            EO.WebBrowser.WebView.ShowDebugUI();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                webView1.EvalScript("stop();");

            }
            else
            {
                if(web_interface) webView1.EvalScript("start(true);");
                else webView1.EvalScript("start(false);");

            }

            button_start.Invoke(new del_bool((s) => button_start.Enabled = s), false);
        }
    }
}
