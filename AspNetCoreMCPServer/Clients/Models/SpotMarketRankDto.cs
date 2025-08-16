using System.ComponentModel;

namespace AspNetCoreMCPServer.Clients.Models;

/// <summary>
/// 现货交易数据排行榜
/// </summary>
[Description("spot market rank data")]
public class SpotMarketRankDto
{
    /// <summary>
    /// 热榜
    /// </summary>
    [Description("hot market rank list")]
    public List<MarketRankItemDTO> Hots { get; set; } = [];


    /// <summary>
    /// 涨幅榜
    /// </summary>
    [Description("gainers market rank list")]
    public List<MarketRankItemDTO> Gainers { get; set; } = [];


    /// <summary>
    /// 跌幅榜
    /// </summary>
    [Description("losers market rank list")]
    public List<MarketRankItemDTO> Losers { get; set; } = [];


    /// <summary>
    /// 24小时成交额榜
    /// </summary>
    [Description("24h trade amount market rank list")]
    public List<MarketRankItemDTO> Last24TradeAmounts { get; set; } = [];
}

public class MarketRankItemDTO
{
    /// <summary>
    /// 现货数字货币交易对标识
    /// </summary>
    [Description("spot market symbol identifier")]
    public string? Symbol { get; set; }

    /// <summary>
    /// 最新价
    /// </summary>
    [Description("latest price")]
    public decimal Newest { get; set; }

    /// <summary>
    /// 最新委买价
    /// </summary>
    [Description("latest buy price")]
    public decimal BuyPrice { get; set; }

    /// <summary>
    /// 最新委买量
    /// </summary>
    [Description("latest buy quantity")]
    public decimal BuyNum { get; set; }

    /// <summary>
    /// 最新委卖价
    /// </summary>
    [Description("latest sell price")]
    public decimal SellPrice { get; set; }

    /// <summary>
    /// 最新委卖量
    /// </summary>
    [Description("latest sell quantity")]
    public decimal SellNum { get; set; }

    /// <summary>
    /// 卖方品种名称
    /// </summary>
    [Description("seller coin name")]
    public string? SellerCoinName { get; set; }

    /// <summary>
    /// 卖方品种编码
    /// </summary>
    [Description("seller coin code")]
    public string? SellerCoinCode { get; set; }

    /// <summary>
    /// 买方品种名称
    /// </summary>
    [Description("buyer coin name")]
    public string? BuyerCoinName { get; set; }

    /// <summary>
    /// 买方品种编码
    /// </summary>
    [Description("buyer coin code")]
    public string? BuyerCoinCode { get; set; }

    /// <summary>
    /// 均价
    /// </summary>
    [Description("average price")]
    public decimal AvgPrice { get; set; }

    /// <summary>
    /// 快速涨幅
    /// </summary>
    [Description("fast rise percentage")]
    public decimal FastRose { get; set; }

    /// <summary>
    /// 涨跌点数
    /// </summary>
    [Description("rise and fall points")]
    public decimal Rise { get; set; }

    /// <summary>
    /// 涨幅
    /// </summary>
    [Description("rise percentage")]
    public decimal Rose { get; set; }

    /// <summary>
    /// 开盘
    /// </summary>
    [Description("opening price")]
    public decimal Open { get; set; }

    /// <summary>
    /// 收盘
    /// </summary>
    [Description("closing price")]
    public decimal Close { get; set; }

    /// <summary>
    /// 最高
    /// </summary>
    [Description("highest price")]
    public decimal High { get; set; }

    /// <summary>
    /// 最低
    /// </summary>
    [Description("lowest price")]
    public decimal Low { get; set; }

    /// <summary>
    /// 最新24H交易量
    /// </summary>
    [Description("latest 24h trade quantity")]
    public decimal Last24TradeQuantity { get; set; }

    /// <summary>
    /// 最新24H USD成交额
    /// </summary>
    [Description("latest 24h trade amount in USD")]
    public decimal Last24TradeUSDAmount { get; set; }

    /// <summary>
    /// 最新24H成交额
    /// </summary>
    [Description("latest 24h trade amount")]
    public decimal Last24TradeAmount { get; set; }

    /// <summary>
    /// 最小买入数量
    /// </summary>
    [Description("minimum buy quantity")]
    public decimal MinBuyQuantity { get; set; }

    /// <summary>
    /// 最小卖出数量
    /// </summary>
    [Description("minimum sell quantity")]
    public decimal MinSellQuantity { get; set; }

    /// <summary>
    /// 买入品种Logo
    /// </summary>
    [Description("buyer coin logo")]
    public string? BuyerCoinLogo { get; set; }

    /// <summary>
    /// 卖出品种Logo
    /// </summary>
    [Description("seller coin logo")]
    public string? SellerCoinLogo { get; set; }

    /// <summary>
    /// 对美元最新价
    /// </summary>
    [Description("latest price against USD")]
    public decimal LastUSDPrice { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [Description("sort order")]
    public int Sort { get; set; }
}
