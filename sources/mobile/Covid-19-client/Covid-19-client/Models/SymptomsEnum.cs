
using System;

namespace Covid19Client.Models
{
    [Flags]
    public enum SymptomsEnum
    {
        None=0,
        BreathingIssue=1,
        Fever=2,
        MuscularPain=4,
        Other=8
    }
}
