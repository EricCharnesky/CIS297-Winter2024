const int STANDARD_MARRIED_DEDUCTIONS = 27_700;
const int END_OF_10_PERCENT_BRACKET_MARRIED_2023 = 22_000;
const int END_OF_12_PERCENT_BRACKET_MARRIED_2023 = 89_450;
const int END_OF_22_PERCENT_BRACKET_MARRIED_2023 = 190_750;
const int END_OF_24_PERCENT_BRACKET_MARRIED_2023 = 364_200;
const int END_OF_32_PERCENT_BRACKET_MARRIED_2023 = 462_500;
const int END_OF_35_PERCENT_BRACKET_MARRIED_2023 = 693_750;

double getTaxesOwedAtBracket(int adjustedGrossIncome, double bracketRate, int bracketStart, int bracketEnd)
{
    if (adjustedGrossIncome > bracketEnd)
    {
        return (bracketEnd - bracketStart) * bracketRate;
    } else if ( adjustedGrossIncome < bracketStart)
    {
        return 0;
    }
    return (adjustedGrossIncome - bracketStart) * bracketRate;
}

int getTotal(string message)
{
    int input = -1;
    int total = 0;

    while (input != 0)
    {
        Console.WriteLine(message);
        input = int.Parse(Console.ReadLine());
        total += input;
    }
    return total;
}

int grossIncome = getTotal("Enter a W2 income or 0 to stop");
int totalDeductions = getTotal("Enter a deduction or 0 to stop");

if ( totalDeductions < STANDARD_MARRIED_DEDUCTIONS)
{
    totalDeductions = STANDARD_MARRIED_DEDUCTIONS;
}

int adjustedGrossIncome = grossIncome - totalDeductions;

if ( adjustedGrossIncome < 0)
{
    adjustedGrossIncome = 0;
}

double taxesOwedAt10Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .10, 0, END_OF_10_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt12Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .12, END_OF_10_PERCENT_BRACKET_MARRIED_2023, END_OF_12_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt22Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .22, END_OF_12_PERCENT_BRACKET_MARRIED_2023, END_OF_22_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt24Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .24, END_OF_22_PERCENT_BRACKET_MARRIED_2023, END_OF_24_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt32Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .32, END_OF_24_PERCENT_BRACKET_MARRIED_2023, END_OF_32_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt35Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .35, END_OF_32_PERCENT_BRACKET_MARRIED_2023, END_OF_35_PERCENT_BRACKET_MARRIED_2023);
double taxesOwedAt37Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .37, END_OF_35_PERCENT_BRACKET_MARRIED_2023, int.MaxValue);


double totalTaxesOwed = taxesOwedAt10Percent + taxesOwedAt12Percent + taxesOwedAt22Percent
    + taxesOwedAt24Percent + taxesOwedAt32Percent + taxesOwedAt35Percent + taxesOwedAt37Percent;

Console.WriteLine($"Taxes owed at 10% - ${taxesOwedAt10Percent} ");
Console.WriteLine($"Taxes owed at 12% - ${taxesOwedAt12Percent} ");
Console.WriteLine($"Taxes owed at 22% - ${taxesOwedAt22Percent} ");
Console.WriteLine($"Taxes owed at 24% - ${taxesOwedAt24Percent} ");
Console.WriteLine($"Taxes owed at 32% - ${taxesOwedAt32Percent} ");
Console.WriteLine($"Taxes owed at 35% - ${taxesOwedAt35Percent} ");
Console.WriteLine($"Taxes owed at 37% - ${taxesOwedAt37Percent} ");

Console.WriteLine($"Total taxes owed: ${totalTaxesOwed}");

Console.WriteLine($"Total taxes owed as % of gross income: {totalTaxesOwed / grossIncome}");
Console.WriteLine($"Total taxes owed as % of adjusted gross income: {totalTaxesOwed / adjustedGrossIncome}");