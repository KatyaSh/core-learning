public class CandidateValidation
{
    private Candidate[] _registeredCandidates;
    public string[] RequiredTitles { get; } = { "Director", "Manager", "Developer", "QA Tester" };

    public CandidateValidation(Candidate[] registeredCandidates)
    {
        _registeredCandidates = registeredCandidates;
    }

    public void ValidateCandidate(Candidate candidate)
    {
        if (candidate == null)
        {
            throw new CandidateException("No candidate information");
        }

        if (candidate.Age < 18 || candidate.Age > 65)
        {
            throw new CandidateException("The candidate's age does not meet the requirements");
        }

        foreach (string title in RequiredTitles)
        {
            if (candidate.Title.Equals(title))
            {
                _registeredCandidates[GetIndex()] = candidate;
                Console.WriteLine($"The candidate {candidate.Name} has been added to the list for consideration.");
                return;
            }
        }
        throw new CandidateException("The candidate does not meet the requirements");
    }

    private int GetIndex()
    {
        for (int i = 0; i < _registeredCandidates.Length; i++)
        {
            if (_registeredCandidates[i] == null)
            {
                return i;
            }
        }

        throw new CandidateException("candidate cannot be taken. All places are taken");
    }
}