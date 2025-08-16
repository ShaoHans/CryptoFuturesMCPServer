using System.ComponentModel;

namespace AspNetCoreMCPServer.Clients.Models;

public class FuturesRealTimeHandicapDto
{
    /// <summary>
    /// 合约标识
    /// </summary>
    [Description("futures symbol")]
    public string? Symbol { get; set; }

    /// <summary>
    /// 第一买价
    /// </summary>
    [Description("first bid price")]
    public decimal? FirstBid { set; get; }

    /// <summary>
    /// 第一卖价
    /// </summary>
    [Description("first ask price")]
    public decimal? FirstAsk { set; get; }

    /// <summary>
    /// 最新市场价
    /// </summary>
    [Description("latest market price")]
    public decimal MarketPrice { get; set; }

    /// <summary>
    /// 序号
    /// </summary>
    [Description("sort order")]
    public long Sort { set; get; }

    /// <summary>
    /// 24小时涨跌幅
    /// </summary>
    [Description("24h change rate")]
    public decimal ChangeRate24H { set; get; }

    /// <summary>
    /// 24小时最高价
    /// </summary>
    [Description("24h high price")]
    public decimal High24H { set; get; }

    /// <summary>
    /// 24小时最低价
    /// </summary>
    [Description("24h low price")]
    public decimal Low24H { set; get; }

    /// <summary>
    /// 24小时成交量
    /// </summary>
    [Description("24h trading volume")]
    public decimal Volume24H { set; get; }

    /// <summary>
    /// 24小时成交额
    /// </summary>
    [Description("24h turnover amount")]
    public decimal Turnover24H { set; get; }

    /// <summary>
    /// 最新标记价
    /// </summary>
    [Description("latest mark price")]
    public decimal MarkPrice { set; get; }

    /// <summary>
    /// 最新指数价
    /// </summary>
    [Description("latest index price")]
    public decimal? IndexPrice { set; get; }

    /// <summary>
    /// 距费用结算时间
    /// </summary>
    [Description("distance settlement time")]
    public string? DistanceSettlementTime { set; get; }

    /// <summary>
    /// 资金费率
    /// </summary>
    [Description("funding rate")]
    public decimal ForecastFundRate { set; get; }

    /// <summary>
    /// 计算资金费率间隔时间
    /// </summary>
    [Description("funding rate calculation interval in hours")]
    public int IntervalHour { get; set; } = 8;
}