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
        }

        [Serializable]
        public class data
        {
            [JsonProperty("price_usd")]
            public float price_usd { get; set; }
            [JsonProperty("market_cap_usd")]
            public float market_cap_usd { get; set; }
            [JsonProperty("24h_volume_usd")]
            public float day_volume_usd { get; set; }
            [JsonProperty("available_supply")]
            public float available_supply { get; set; }
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
                }
            }
        }
    }
}
