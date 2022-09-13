using Xunit;
using Main;
using DictionaryBinaryTreeLib;

namespace TestingDictionary.Test;
public class BinaryTreeTests
{
    [Fact]
    public void SearchValues()
    {
        // arrange
        int[] keys = DataBase.DataBaseLoading(100);
        BinaryTree<int, string> BinaryTree = DataBase.BinaryTreeLoading(keys);

        int key = 30;
        string value = "!30!";

        // act
        string rezult = BinaryTree.Search(key);

        // assert
        Assert.Equal(value, rezult);
    }

    [Fact]
    public void ExepctionSearchValues()
    {
        // arrange
        int[] keys = DataBase.DataBaseLoading(100);
        BinaryTree<int, string> BinaryTree = DataBase.BinaryTreeLoading(keys);

        int key = 1000;
        string valueExepction = "no such element";
        // act
        var ex = Assert.Throws<Exception>(() => BinaryTree.Search(key));

        // assert
        Assert.Equal(valueExepction, ex.Message);
    }
}