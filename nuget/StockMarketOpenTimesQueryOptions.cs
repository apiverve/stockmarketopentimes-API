using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.StockMarketOpenTimes
{
    /// <summary>
    /// Query options for the Stock Market Open Times API
    /// </summary>
    public class StockMarketOpenTimesQueryOptions
    {
        /// <summary>
        /// The stock exchange for which you want to get the open times (e.g. NYSE, NASDAQ, BATS, CHX, PHLX, AMEX, ARCA, ISE, CBOE, LSE, FWB, TSE, HKEX, ASX, BSE, JSE, SSE, SZSE, SGX, EURONEXT, TSX, MOEX, SIX, BIST, JPX, KRX, IDX, SET, MYX, TWSE, HOSE, DFM, ADX, QSE, EGX, BCB, BVSP, BVC, BMV, KSE, TAWUDAL)
        /// Example: nyse
        /// </summary>
        [JsonProperty("exchange")]
        public string Exchange { get; set; }
    }
}
