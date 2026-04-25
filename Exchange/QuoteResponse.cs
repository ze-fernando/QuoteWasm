namespace Price.Exchange;

public record Quote(
    string Code,
    string Bid,
    string PctChange,
    string Create_Date
);

public record QuoteResponse
{
    public Quote? USDBRL { get; init; }
    public Quote? EURBRL { get; init; }
    public Quote? BTCBRL { get; init; }
}