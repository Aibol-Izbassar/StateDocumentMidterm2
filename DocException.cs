using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermOODP2_Second
{
    class DocException:Exception
    {
        public override string Message => "У документа больше 5 голосов";
    }

    class VoteException : Exception
    {
        public override string Message => "У документа меньше 5 голосов";
    }
    class SignatureException : Exception
    {
        public override string Message => "У документа меньше 2 подписей";
    }

    class ApprovalException : Exception
    {
        public override string Message => "У документа есть подпись";
    }
}
