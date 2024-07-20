using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveUEFNUtility
{
    public class Vector3
    {
        // X, Y, Zのプロパティ
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        // コンストラクタ
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // 文字列表現を返すメソッド
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}