using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SungSiKyung.Script.Utils
{
    public struct Vector2 : IEquatable<Vector2>
    {
        public float x;
        public float y;
        public float Magnitude { get; }
        public Vector2 normalized => this / Magnitude;
        public float SqrMagnitude { get; }
        public static Vector2 zero { get; } = new Vector2(0, 0);
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
            SqrMagnitude = x * x + y * y;
            Magnitude = MathF.Sqrt(SqrMagnitude);
        }
        public bool Equals(Vector2 other)
        {
            return x == other.x && y == other.y;
        }
        public void Scale(Vector2 scale)
        {
            this = new Vector2(x * scale.x, y * scale.y);
        }
        public void Set(float newX, float newY)
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
        public static float Angle(Vector2 from,Vector2 to)
        {
            return MathF.Acos(Dot(from.normalized, to.normalized))*57.2958f;
        }
        public static float Distance(Vector2 a, Vector2 b)
        {
            return (a - b).Magnitude;
        }
        public static float Dot(Vector2 a, Vector2 b)
        {
            return a.x * b.x + a.y * b.y;
        }
        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            if(t > 1) { return b; }
            if (t < 0) { return a; }
            return a*(1-t) + b*t;
        }
        public static Vector2 LerpUnClamped(Vector2 a,Vector2 b,float t)
        {
            return a * (1 - t) + b * t;
        }
        public static float SignedAngle(Vector2 from,Vector2 to)
        {
            return from.x * to.y - from.y * to.x > 0 ? Angle(from, to) : -Angle(from, to);
        }
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }
        public static Vector2 operator -(Vector2 a)
        {
            return new Vector2(-a.x, -a.y);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }
        public static Vector2 operator *(Vector2 a, float d)
        {
            return new Vector2(a.x * d, a.y * d);
        }
        public static Vector2 operator *(float d, Vector2 b)
        {
            return new Vector2(d * b.x, d * b.y);
        }
        public static Vector2 operator /(Vector2 a, float d)
        {
            return new Vector2(a.x / d, a.y / d);
        }
        public static bool operator == (Vector2 left, Vector2 right)
        {
            return Equals(left, right);
        }
        public static bool operator != (Vector2 left, Vector2 right)
        {
            return !Equals(left, right);
        }
        //public static implicit operator Vector2Int(Vector2 vector)
        //{
        //    return new Vector2Int((int)vector.x, (int)vector.y);
        //}
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
