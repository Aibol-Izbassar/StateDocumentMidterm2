using System;

namespace MidTermOODP2_Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc1 = new Document("Document 1");
            DocumentProcess dc1 = new DocumentProcess(doc1);
            try
            {
                doc1.VoteDoc();
                doc1.VoteDoc();
                doc1.VoteDoc();


                Console.WriteLine("После двух голосов  " + dc1.documentState);

                doc1.VoteDoc();
                doc1.VoteDoc();
                dc1.NextStage();

                Console.WriteLine("После 5 голосов  "+dc1.documentState);
                doc1.SignatureDoc();
                doc1.SignatureDoc();
                dc1.NextStage();
                Console.WriteLine("После 2 подписей  " + dc1.documentState);

                doc1.ApprovalDoc();
                
                dc1.NextStage();
            }
            catch (VoteProcessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SignatureProcessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ApprovalProcessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FinalProcessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DocException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (VoteException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SignatureException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ApprovalException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
