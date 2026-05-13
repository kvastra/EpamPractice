namespace Tools;

public static class ErrorMessages
{
    public const string IncorrectValueOfSidesError =
        "Incorrect value of sides: the sum of two sides must not be greater than the third.";

    public const string IncorrectTypeError = "Incorrect type.";

    public const string IncorrectArgCountError = "Incorrect arguments count.";

    public static string GetValueMustBeGreaterThanZeroError(string variableName) =>
        $"{variableName} must have value that greater than zero.";
    
    public static string GetValueMustBePositiveError(string variableName) =>
        $"{variableName} must have a positive value.";

    public static string GetMustHaveValueError(string variableName) => $"{variableName} must have value.";

    public static string GetStringMustConsistLettersOnlyError(string variableName) =>
        $"{variableName} must consist of letters only.";
}