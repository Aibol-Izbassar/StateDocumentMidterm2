using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermOODP2_Second
{
    enum DocumentState {Vote, Signature, Approval}
    class DocumentProcess
    {
        Document doc;
        public DocumentState documentState { get; private set; } = DocumentState.Vote;
        private IState state = new Vote();
       
        public DocumentProcess(Document doc)
        {
            this.doc = doc;
        }
        
        interface IState
        {
            IState NextStage(DocumentProcess dc);
        }

        class Vote : IState
        {
            public IState NextStage(DocumentProcess dc)
            {
                if (dc.doc.DocVote == 5) 
                {
                    dc.documentState = DocumentState.Signature;
                    return new Signature();
                }
                else
                {
                    throw new VoteProcessException();
                }
            }
        }

        class Signature : IState
        {
            public IState NextStage(DocumentProcess dc)
            {
                if (dc.doc.DocSignature == 2) 
                {
                    dc.documentState = DocumentState.Approval;
                    return new Approval();
                }
                else
                {
                    throw new SignatureProcessException();
                }
            }
        }

        class Approval : IState
        {
            public IState NextStage(DocumentProcess dc)
            {
                if (dc.doc.DocApproval == 1)
                {
                    Console.WriteLine($"{dc.doc.GetName} прошел весь процес");
                    return new FinalState();
                }
                else
                {
                    throw new ApprovalProcessException();
                }
            }
        }
        class FinalState : IState
        {
            public IState NextStage(DocumentProcess dc)
            {
                throw new FinalProcessException();
            }
        }

        public void NextStage()
        {
            state = state.NextStage(this);
        }
    }
}
