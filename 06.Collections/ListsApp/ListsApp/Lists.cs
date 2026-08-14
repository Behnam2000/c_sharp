namespace ListsApp;

internal class Lists
{
    private List<int> _numbers = new List<int> { 10, 5, 15, 3, 23, 9, 7, 18 };

    public List<int> Numbers
    {
        get
        {
            return _numbers;
        }
    }

}