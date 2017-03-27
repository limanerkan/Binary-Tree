namespace binaryTree
{
    class TreeNode
    {
        private TreeNode solDugum;
        private TreeNode sagDugum;
        private int data;

        #region
        public TreeNode SolDugum
        {
            get
            {
                return solDugum;
            }

            set
            {
                solDugum = value;
            }
        }

        public TreeNode SagDugum
        {
            get
            {
                return sagDugum;
            }

            set
            {
                sagDugum = value;
            }
        }

        public int Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
        #endregion



        //node constructor
        public TreeNode(int dugumDatasi)
        {
            data = dugumDatasi;
            SagDugum = null; //ilk oluşturduğumuzda sag ve sol dugumleri yok
            SolDugum = null;
        }

        public void Ekle(int eklenecekData)
        {
            //eğer eklenecek data kendi datadan küçük ise sola ekle
            if (eklenecekData < data)
            {
                if (solDugum == null)
                    solDugum = new TreeNode(eklenecekData);
                else
                    solDugum.Ekle(eklenecekData);
            }
            //eğer eklenecek data kendi datadan büyük ise sağa ekle
            else if (eklenecekData > data)
            {
                if (sagDugum == null)
                    sagDugum = new TreeNode(eklenecekData);
                else
                    sagDugum.Ekle(eklenecekData);
            }
            
        }


    }
}
