using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoStats
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dataTimer.Start();
            getData();
        }

        [Serializable]
        public class data
        {
            [JsonProperty("price")]
            public float price { get; set; }

            [JsonProperty("market_cap")]
            public double marketCap { get; set; }

            [JsonProperty("volume")]
            public float volume { get; set; }

            [JsonProperty("supply")]
            public double supply { get; set; }

            [JsonProperty("cap24hrChange")]
            public float percentChange { get; set; }
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string btcJson = client.DownloadString("http://coincap.io/page/BTC/");
                    string ethJson = client.DownloadString("http://coincap.io/page/ETH/");
                    string ltcJson = client.DownloadString("http://coincap.io/page/LTC/");
                    string adaJson = client.DownloadString("http://coincap.io/page/ADA/");
                    string xmrJson = client.DownloadString("http://coincap.io/page/XMR/");
                    string vtcJson = client.DownloadString("http://coincap.io/page/VTC/");
                    string navJson = client.DownloadString("http://coincap.io/page/NAV/");
                    string grsJson = client.DownloadString("http://coincap.io/page/GRS/");

                    btcJson = format(btcJson);
                    ethJson = format(ethJson);
                    ltcJson = format(ltcJson);
                    adaJson = format(adaJson);
                    xmrJson = format(xmrJson);
                    vtcJson = format(vtcJson);
                    navJson = format(navJson);
                    grsJson = format(grsJson);

                    data bitcoin = JsonConvert.DeserializeObject<data>(btcJson);
                    data ether = JsonConvert.DeserializeObject<data>(ethJson);
                    data litecoin = JsonConvert.DeserializeObject<data>(ltcJson);
                    data cardano = JsonConvert.DeserializeObject<data>(adaJson);
                    data monero = JsonConvert.DeserializeObject<data>(xmrJson);
                    data vertcoin = JsonConvert.DeserializeObject<data>(vtcJson);
                    data nav = JsonConvert.DeserializeObject<data>(navJson);
                    data groestl = JsonConvert.DeserializeObject<data>(grsJson);


                    // Bitcoin
                    btcPrice.Text = bitcoin.price.ToString("C");
                    btcMarketCap.Text = bitcoin.marketCap.ToString("C0");
                    btcVolume.Text = bitcoin.volume.ToString("C0");
                    btcSupply.Text = bitcoin.supply.ToString("N0");
                    btcChange.Text = bitcoin.percentChange.ToString() + "%";

                    // Ethereum
                    ethPrice.Text = ether.price.ToString("C");
                    ethMarketCap.Text = ether.marketCap.ToString("C0");
                    ethVolume.Text = ether.volume.ToString("C0");
                    ethSupply.Text = ether.supply.ToString("N0");
                    ethChange.Text = ether.percentChange.ToString() + "%";

                    // Litecoin
                    ltcPrice.Text = litecoin.price.ToString("C");
                    ltcMarketCap.Text = litecoin.marketCap.ToString("C0");
                    ltcVolume.Text = litecoin.volume.ToString("C0");
                    ltcSupply.Text = litecoin.supply.ToString("N0");
                    ltcChange.Text = litecoin.percentChange.ToString() + "%";

                    // Cardano
                    adaPrice.Text = cardano.price.ToString("C");
                    adaMarketCap.Text = cardano.marketCap.ToString("C0");
                    adaVolume.Text = cardano.volume.ToString("C0");
                    adaSupply.Text = cardano.supply.ToString("N0");
                    adaChange.Text = cardano.percentChange.ToString() + "%";

                    // Monero
                    xmrPrice.Text = monero.price.ToString("C");
                    xmrMarketCap.Text = monero.marketCap.ToString("C0");
                    xmrVolume.Text = monero.volume.ToString("C0");
                    xmrSupply.Text = monero.supply.ToString("N0");
                    xmrChange.Text = monero.percentChange.ToString() + "%";

                    // Vertcoin
                    vtcPrice.Text = vertcoin.price.ToString("C");
                    vtcMarketCap.Text = vertcoin.marketCap.ToString("C0");
                    vtcVolume.Text = vertcoin.volume.ToString("C0");
                    vtcSupply.Text = vertcoin.supply.ToString("N0");
                    vtcChange.Text = vertcoin.percentChange.ToString() + "%";

                    // NAV
                    navPrice.Text = nav.price.ToString("C");
                    navMarketCap.Text = nav.marketCap.ToString("C0");
                    navVolume.Text = nav.volume.ToString("C0");
                    navSupply.Text = nav.supply.ToString("N0");
                    navChange.Text = nav.percentChange.ToString() + "%";

                    // Groestl
                    grsPrice.Text = groestl.price.ToString("C");
                    grsMarketCap.Text = groestl.marketCap.ToString("C0");
                    grsVolume.Text = groestl.volume.ToString("C0");
                    grsSupply.Text = groestl.supply.ToString("N0");
                    grsChange.Text = groestl.percentChange.ToString() + "%";
                }            
            }
            catch(Exception)
            {
                dataTimer.Stop();
            }
        }

        private string format(string json)
        {
            json = json.Replace("[", "");
            json = json.Replace("]", "");
            return json;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
    }
}
