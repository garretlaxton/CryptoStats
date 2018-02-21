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
            [JsonProperty("price_usd")]
            public float price_usd { get; set; }
            [JsonProperty("market_cap_usd")]
            public double market_cap_usd { get; set; }
            [JsonProperty("24h_volume_usd")]
            public float day_volume_usd { get; set; }
            [JsonProperty("available_supply")]
            public double available_supply { get; set; }
            [JsonProperty("percent_change_24h")]
            public float percent_change_24h { get; set; }
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
                    string btcJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/bitcoin/");
                    string ethJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/ethereum/");
                    string ltcJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/litecoin/");
                    string adaJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/cardano/");
                    string xmrJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/monero/");
                    string vtcJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/vertcoin/");
                    string navJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/nav-coin/");
                    string grsJson = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/groestlcoin/");

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
                    btcPrice.Text = bitcoin.price_usd.ToString("C");
                    btcMarketCap.Text = bitcoin.market_cap_usd.ToString("C0");
                    btcVolume.Text = bitcoin.day_volume_usd.ToString("C0");
                    btcSupply.Text = bitcoin.available_supply.ToString("N0");
                    btcChange.Text = bitcoin.percent_change_24h.ToString() + "%";

                    // Ethereum
                    ethPrice.Text = ether.price_usd.ToString("C");
                    ethMarketCap.Text = ether.market_cap_usd.ToString("C0");
                    ethVolume.Text = ether.day_volume_usd.ToString("C0");
                    ethSupply.Text = ether.available_supply.ToString("N0");
                    ethChange.Text = ether.percent_change_24h.ToString() + "%";

                    // Litecoin
                    ltcPrice.Text = litecoin.price_usd.ToString("C");
                    ltcMarketCap.Text = litecoin.market_cap_usd.ToString("C0");
                    ltcVolume.Text = litecoin.day_volume_usd.ToString("C0");
                    ltcSupply.Text = litecoin.available_supply.ToString("N0");
                    ltcChange.Text = litecoin.percent_change_24h.ToString() + "%";

                    // Cardano
                    adaPrice.Text = cardano.price_usd.ToString("C");
                    adaMarketCap.Text = cardano.market_cap_usd.ToString("C0");
                    adaVolume.Text = cardano.day_volume_usd.ToString("C0");
                    adaSupply.Text = cardano.available_supply.ToString("N0");
                    adaChange.Text = cardano.percent_change_24h.ToString() + "%";

                    // Monero
                    xmrPrice.Text = monero.price_usd.ToString("C");
                    xmrMarketCap.Text = monero.market_cap_usd.ToString("C0");
                    xmrVolume.Text = monero.day_volume_usd.ToString("C0");
                    xmrSupply.Text = monero.available_supply.ToString("N0");
                    xmrChange.Text = monero.percent_change_24h.ToString() + "%";

                    // Vertcoin
                    vtcPrice.Text = vertcoin.price_usd.ToString("C");
                    vtcMarketCap.Text = vertcoin.market_cap_usd.ToString("C0");
                    vtcVolume.Text = vertcoin.day_volume_usd.ToString("C0");
                    vtcSupply.Text = vertcoin.available_supply.ToString("N0");
                    vtcChange.Text = vertcoin.percent_change_24h.ToString() + "%";

                    // NAV
                    navPrice.Text = nav.price_usd.ToString("C");
                    navMarketCap.Text = nav.market_cap_usd.ToString("C0");
                    navVolume.Text = nav.day_volume_usd.ToString("C0");
                    navSupply.Text = nav.available_supply.ToString("N0");
                    navChange.Text = nav.percent_change_24h.ToString() + "%";

                    // Groestl
                    grsPrice.Text = groestl.price_usd.ToString("C");
                    grsMarketCap.Text = groestl.market_cap_usd.ToString("C0");
                    grsVolume.Text = groestl.day_volume_usd.ToString("C0");
                    grsSupply.Text = groestl.available_supply.ToString("N0");
                    grsChange.Text = groestl.percent_change_24h.ToString() + "%";
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
    }
}
