using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Strategies;

public interface IExecutionStrategy
{
    void Execute(Student student, IProgram program);
}