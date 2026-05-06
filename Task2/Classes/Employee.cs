using Tools;

namespace Task2.Classes;

public class Employee : User
{
    /// <summary>
    /// Опыт работы
    /// </summary>
    private int WorkExperience { get; set; }
    
    /// <summary>
    /// Должность
    /// </summary>
    private string JobTitle { get; set; }
    
    public Employee(string firstName, string lastName, string middleName, DateTime dateOfBirth, int workExperience, string jobTitle) 
        : base(firstName, lastName, middleName, dateOfBirth)
    {
        if (workExperience < 0)
            throw new Exception(ErrorMessages.GetValueMustBeGreaterThanZeroError(nameof(WorkExperience)));

        if (string.IsNullOrEmpty(jobTitle))
            throw new Exception(ErrorMessages.GetMustHaveValueError(nameof(JobTitle)));
        
        if (!jobTitle.All(char.IsLetter))
            throw new Exception(ErrorMessages.GetStringMustConsistLettersOnlyError("Job title"));
        
        WorkExperience = workExperience;
        JobTitle = jobTitle;
    }
}