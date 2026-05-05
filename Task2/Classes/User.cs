using Tools;

namespace Task2.Classes;

public class User
{
    /// <summary>
    /// Имя
    /// </summary>
    private string FirstName { get; set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    private string LastName { get; set; }
    
    /// <summary>
    /// Отчество
    /// </summary>
    private string MiddleName { get; set; }
    
    /// <summary>
    /// Дата рождения
    /// </summary>
    private DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Возраст
    /// </summary>
    public int Age => (DateTime.MinValue + (DateTime.Now - DateOfBirth)).Year - 1;

    public User(string firstName, string lastName, string middleName, DateTime dateOfBirth)
    {
        if (string.IsNullOrEmpty(firstName))
            throw new Exception(ErrorMessages.GetMustHaveValueError("First name"));
        
        if (string.IsNullOrEmpty(lastName))
            throw new Exception(ErrorMessages.GetMustHaveValueError("Last name"));

        if (!firstName.All(char.IsLetter))
            throw new Exception(ErrorMessages.GetStringMustConsistLettersOnlyError("First name"));
        
        if (!lastName.All(char.IsLetter))
            throw new Exception(ErrorMessages.GetStringMustConsistLettersOnlyError("Last name"));
        
        if (!middleName.All(char.IsLetter))
            throw new Exception(ErrorMessages.GetStringMustConsistLettersOnlyError("Middle name"));
        
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        DateOfBirth = dateOfBirth;
    }
}