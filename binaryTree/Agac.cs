using System;

namespace binaryTree
{
    public class Agac
    {
        private TreeNode kok;

        public Agac()
        {
            kok = null; //ağaç ilk oluşturulduğunda kökü boş olacak 
        }

        public void DugumEkle(int eklenecekDeger)
        {
            lock (this)
            {
                if (kok == null)
                    kok = new TreeNode(eklenecekDeger);
                else
                    kok.Ekle(eklenecekDeger);
            }
        }

        public void OnceKokGezme()
        {
            lock (this)
            {
                OnceKokGezmeHelper(kok);
            }
        }

        private void OnceKokGezmeHelper(TreeNode kok)
        {
            if (kok == null)
                return;

            Console.Write(kok.Data + " ");

            OnceKokGezmeHelper(kok.SolDugum);
            OnceKokGezmeHelper(kok.SagDugum);
        }

        public void IcKokGezme()
        {
            lock (this)
            {
                IcKokGezmeHelper(kok);
            }
        }


        private void IcKokGezmeHelper(TreeNode kok)
        {
            if (kok == null)
                return ;

            IcKokGezmeHelper(kok.SolDugum);
            Console.Write(kok.Data + " ");
            IcKokGezmeHelper(kok.SagDugum);
        }




        public void SonraKokGezme()
        {
            lock (this)
            {
                SonraKokGezmeHelper(kok);
            }
        }



        private void SonraKokGezmeHelper(TreeNode kok)
        {
            if (kok == null)
                return;
            SonraKokGezmeHelper(kok.SolDugum);
            SonraKokGezmeHelper(kok.SagDugum);
            Console.Write(kok.Data + " ");
        }
    }
}