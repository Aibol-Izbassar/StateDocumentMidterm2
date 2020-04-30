using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermOODP2_Second
{
    class ProcessException:Exception
    {
    }
    class VoteProcessException:Exception
    {
        public override string Message => "Не хватает голосов";
    }
    class SignatureProcessException : Exception
    {
        public override string Message => "Не хватает подписей";
    }

    class ApprovalProcessException : Exception
    {
        public override string Message => "Не хватает подпися для утверждения!";
    }

    class FinalProcessException : Exception
    {
        public override string Message => "Все этапы пройдены!";
    }
}
