using task1;

namespace TestTask1
{
    [TestClass]
    public class TestArrayOfLists
    {
        [TestMethod]
        public void TestResize()
        {
            
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++) 
            {
                Array<ListNode<int>> testarray = new Array<ListNode<int>>();
                int index = i*rnd.Next(0,10);
                testarray.Insert(index,i);
                Assert.AreEqual(index, testarray.Length - 1);
            
            }

        }

        [TestMethod]
        public void TestInsert()
        {
            Array<ListNode<int>> testarray = new Array<ListNode<int>>();
            for(int i = 0;i < 1000; i++)
            {
                testarray.Insert(0,i);
            }

            Assert.AreEqual(1, testarray.Length);

            int[] actual = testarray.Get(0).GetAll();
            for(int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(i, actual[i]);
            }
        }
    }
}