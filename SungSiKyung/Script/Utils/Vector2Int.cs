using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SungSiKyung.Script.Utils
{
    public struct Vector2Int :IEquatable<Vector2Int> 
    {
        public int x;
        public int y;
        public float Magnitude { get; }
        public Vector2 normalized => this / Magnitude;
        public int sqrMagnitude { get; }
        public static Vector2Int zero { get; } = new Vector2Int(0, 0);
        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
            sqrMagnitude = x * x + y * y;
            Magnitude = MathF.Sqrt(sqrMagnitude);
        }
        public bool Equals(Vector2Int other)
        {
            return x == other.x && y == other.y;
        }
        public void Scale(Vector2Int scale)
        {
            this = new Vector2Int(x * scale.x, y * scale.y);
        }
        public void Set(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        /// <summary>
        /// returns the unsigned angle in degrees between from and to
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static Vector2Int RoundToInt(Vector2 vector)
        {
            return new Vector2Int((int)vector.x, (int)vector.y);
        }
        public static float Angle(Vector2Int from, Vector2Int to)
        {
            return MathF.Acos(Vector2.Dot(from.normalized, to.normalized)) * 57.2958f;
        }
        public static float Distance(Vector2Int a, Vector2Int b)
        {
            return (a - b).Magnitude;
        }
        public static int Dot(Vector2Int a, Vector2Int b)
        {
            return a.x * b.x + a.y * b.y;
        }
        //public static Vector2 Lerp(Vector2Int a, Vector2Int b, float t)
        //{
        //    if (t > 1) { return b; }
        //    if (t < 0) { return a; }
        //    return a * (1 - t) + b * t;
        //}
        //public static Vector2 LerpUnClamped(Vector2Int a, Vector2Int b, float t)
        //{
        //    return a * (1 - t) + b * t;
        //}
        public static float SignedAngle(Vector2Int from, Vector2Int to)
        {
            return from.x * to.y - from.y * to.x > 0 ? Angle(from, to) : -Angle(from, to);
        }
        public static Vector2Int operator +(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x + b.x, a.y + b.y);
        }
        public static Vector2Int operator -(Vector2Int a)
        {
            return new Vector2Int(-a.x, -a.y);
        }
        public static Vector2Int operator -(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x - b.x, a.y - b.y);
        }
        public static Vector2Int operator *(Vector2Int a, int d)
        {
            return new Vector2Int(a.x * d, a.y * d);
        }
        public static Vector2Int operator *(int d, Vector2Int b)
        {
            return new Vector2Int(d * b.x, d * b.y);
        }
        public static Vector2Int operator /(Vector2Int a, int d)
        {
            return new Vector2Int(a.x / d, a.y / d);
        }
        public static Vector2 operator /(Vector2Int a, float d)
        {
            return new Vector2(a.x / d, a.y / d);
        }
        public static bool operator ==(Vector2Int left, Vector2Int right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Vector2Int left, Vector2Int right)
        {
            return !Equals(left, right);
        }
        public static implicit operator Vector2(Vector2Int vector)
        {
            return new Vector2(vector.x, vector.y);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
