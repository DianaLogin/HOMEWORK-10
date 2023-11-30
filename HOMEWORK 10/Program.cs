
namespace HOMEWORK_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================== Домашнее задание 11.1 ========================================

            uint building_1 = Creator.CreateBuild(3.00, 2);
            uint building_2 = Creator.CreateBuild(67.00, 1007, 7);

            Creator.Remove_Build(building_1);
            Creator.Remove_Build(building_2);
        }
    }
}

