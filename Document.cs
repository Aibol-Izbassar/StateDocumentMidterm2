using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermOODP2_Second
{
    class Document
    {
        string _name;
        int Vote = 0;
        int Signature = 0;
        int Approval = 0;
        public Document(string Name)
        {
            _name = Name;
        }
        public string GetName { get { return _name; } }
        public int DocSignature { get { return Signature; }}
        public int DocVote { get { return Vote; }}
        public int DocApproval { get { return Approval; } }

        public void VoteDoc()
        {
            if (Vote>5)
            {
                throw new DocException();
            }
            Vote++;
        }

        public void SignatureDoc()
        {
            if (Vote == 5)
            {
                if (Signature > 2)
                {
                    throw new SignatureException();
                }
                Signature++;
            }
            else
                Console.WriteLine("Документ еще не набрал 5 Гголосов!");
           
        }

        public void ApprovalDoc()
        {
            if (Signature == 2)
            {
                if (Approval == 0)
                {
                    Approval++;
                }
                else
                    throw new ApprovalException();
            }
            else
                Console.WriteLine("Документ еще не набрал 2 подписей!");

        }


    }
}
