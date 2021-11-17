﻿namespace LanguageFeatures.CS10;

public class WithExpressionsAnonymousTypes
{
    [Fact]
    public void Test()
    {
        var anon = new { First = "Jim", Last = "Wooley" };
        var legal = anon with { First = "James" };
        Assert.Equal("James Wooley", $"{legal.First} {legal.Last}");
    }
}
