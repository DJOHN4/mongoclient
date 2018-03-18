using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoClientTool
{
    public class StockPosition : Entity
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string _id { get; set; }
        public string Symbol { get; set; }
        public decimal TotalCount { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal TotalBuyFee { get; set; }
        public decimal TotalCost { get; set; }
        public decimal ExpectedSellPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal TotalSellFee { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal ProfitnLoss { get; set; }
        public decimal ProfitPercentage { get; set; }
        public short Index { get; set; }
        public string Status { get; set; }
         [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreatedOn { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime ModifiedOn { get; set; }
        public string OrderId { get; set; }
        public string Identifier { get; set; }
        public List<StockData> TradeList { get; set; }
        public StrategyInfo StrategyData { get; set; }
   
        public StockPosition(string symbol, decimal count, decimal cost, decimal price, decimal brockrage)
        {
            this.Symbol = symbol;
            this.TotalCount = count;
            this.TotalCost = cost;
            this.AveragePrice = price;
            this.TotalBuyFee = brockrage;
            this.TotalSellFee = 0;
            this.StrategyData = new StrategyInfo();
            this.TradeList = new List<StockData>();
            this.TradeList.Add(new StockData(count, cost, price, brockrage));
            this.UpdateExpectedPrice();
            this.CreatedOn = DateTime.Now;
            this.Index = 0;
            this.ModifiedOn = this.TradeList[this.Index].purchaseTime;
            this.Status = "ACTIVE";
        }
        public bool AddMoreStocks(decimal count, decimal cost, decimal price, decimal brokerFee)
        {
            bool rtnVal = false;
            try
            {
                this.TotalCount += count;
                this.TotalCost += cost;
                this.TotalBuyFee += brokerFee;
                this.AveragePrice = (this.AveragePrice + price) / (this.Index + 2);
                this.TradeList.Add(new StockData(count, cost, price, brokerFee));
                this.UpdateExpectedPrice();
                this.Index++;
                this.ModifiedOn = this.TradeList[this.Index].purchaseTime;
                rtnVal = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return rtnVal;
        }
        //public bool IsReadyToSell(decimal currentPrice, decimal profitPercent, string mode)
        //{
        //    bool rtnVal = false;
        //    decimal feepercent = 0.000m;
        //    decimal multi = this.Index + 1;
        //    decimal grossRevenue = currentPrice * this.TotalCount;
        //    decimal revenue = grossRevenue - (grossRevenue * feepercent);
        //    var profit = revenue - this.TotalCost;
        //    decimal forecastprofit = 0.0m;
        //    if (mode == "FIXED")
        //        forecastprofit = this.StrategyData.FixedProfitValue;//Convert.ToDecimal(ConfigurationManager.AppSettings["FixedProfitValue"]);
        //    else if (mode == "VARIABLE")
        //        forecastprofit = this.TotalCost * (profitPercent / 100);
        //    if (profit >= forecastprofit)
        //        rtnVal = true;
        //    else
        //        rtnVal = false;

        //    return rtnVal;
        //}
        private void UpdateExpectedPrice()
        {
            if (this.StrategyData.SellMode == "FIXED")
                this.ExpectedSellPrice = (this.StrategyData.FixedProfitValue + TotalCost) / this.TotalCount;
            else if (this.StrategyData.SellMode == "VARIABLE")
                this.ExpectedSellPrice = this.TotalCost + (this.TotalCost * (this.StrategyData.SellProfitPercent / 100)) / this.TotalCount;
        }
        public bool IsPriceDownForThisStock(decimal currentPrice)
        {
            bool rtnVal = false;
            decimal downPercent = this.StrategyData.PriceDownPercentage;//Convert.ToDecimal(ConfigurationManager.AppSettings["PriceDownPercentage"]) / 100;
            var subObj = this.TradeList[this.Index];
            var priceHike = subObj.price - (subObj.price * downPercent);
            if (currentPrice <= priceHike)
                rtnVal = true;

            return rtnVal;
        }
    }
    public class StockData
    {
        public decimal count { get; set; }
        public decimal cost { get; set; }
        public decimal price { get; set; }
        public decimal fee { get; set; }
        public DateTime purchaseTime { get; set; }

        public StockData(decimal count, decimal cost, decimal price, decimal charge)
        {
            this.count = count;
            this.cost = cost;
            this.price = price;
            this.fee = charge;
            this.purchaseTime = DateTime.Now;
        }
    }
    public class StrategyInfo
    {
        public string StrategyId { get; set; }
        public string Name { get; set; }
        public string Market { get; set; }
        public decimal SellProfitPercent { get; set; }
        public string SellMode { get; set; }
        public decimal FixedProfitValue { get; set; }
        public decimal PriceDownPercentage { get; set; }
        public int MinPositionLevel { get; set; }
        public int MaxPositionCount { get; set; }
        public decimal ExtrapolateCount { get; set; }
        public decimal ExtrapolateIndex { get; set; }
        public decimal Principle { get; set; }
        public decimal PriceRangeStart { get; set; }
        public decimal PriceRangeEnd { get; set; }

        //public StrategyInfo(string id, string spp, string sm, string fpv, string pdp, string mpl, string mpc, string ec, string ei, string p, string prs, string pre)
        //{
        //    SellProfitPercent = Convert.ToDecimal(spp);
        //    SellMode = sm;
        //    FixedProfitValue = Convert.ToDecimal(fpv);
        //    PriceDownPercentage = Convert.ToDecimal(pdp);
        //    MinPositionLevel = Convert.ToInt32(mpl);
        //    MaxPositionCount = Convert.ToInt32(mpc);
        //    ExtrapolateCount = Convert.ToInt16(ec);
        //    ExtrapolateIndex = Convert.ToInt16(ei);
        //    Principle = Convert.ToDecimal(p);
        //    PriceRangeStart = Convert.ToDecimal(prs);
        //    PriceRangeEnd = Convert.ToDecimal(pre);
        //    StrategyId = id;
        //}

    }
}
