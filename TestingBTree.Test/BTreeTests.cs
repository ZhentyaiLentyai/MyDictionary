using Xunit;
using Main;
using DictionaryBTreeLib;

namespace TestingDictionary.Test;

public class BTreeTests
{
    [Fact]
    public void SearchValues()
    {
        // arrange
        int[] keys = DataBase.DataBaseLoading(100);
        BTree<int, string> BTree = DataBase.BTreeLoading(keys);

        int key = 30;
        string value = "!30!";

        // act
        string rezult = BTree.Search(key);

        // assert
        Assert.Equal(value, rezult);
    }

    [Fact]
    public void ExepctionSearchValues()
    {
        // arrange
        int[] keys = DataBase.DataBaseLoading(100);
        BTree<int, string> BTree = DataBase.BTreeLoading(keys);

        int key = 1000;
        string valueExepction = "no such element";
        // act
        var ex = Assert.Throws<Exception>(() => BTree.Search(key));

        // assert
        Assert.Equal(valueExepction, ex.Message);
    }
}