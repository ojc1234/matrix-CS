// See https://aka.ms/new-console-template for more information

namespace martixDiscord
{
    class Program
    {
        public static void Main(string[] args)
        {
            var matrix2D = new Matrix(new List<int> { 1, 2 },new List<int> { 3, 4 });
            var tempMat = matrix2D.Deepcopy();
            matrix2D.Write();
            matrix2D.Scalar(3);
            matrix2D.Write();
            matrix2D.MatrixAdd(tempMat);
            matrix2D.Write();

        }
    }
}
