using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Conquest
{
    public enum TweenType
    {
        Instant,
        Linear,
        QuadraticInOut,
        CubicInOut,
        QuarticOut
    }

    public class Camera
    {
        private Vector2 _position;
        public double _rotation;
        public double _zoom;

        private Vector2 _positionGoto, _positionFrom;
        private TweenType _tweenType;
        private int _currentStep, _tweenSteps;

        public Vector2 Position
        {
            get
            {
                return _position;
            }
        }

        public Camera(Vector2 _initialPosition, double _initialZoom = 1.0, double _initialRotation = 0.0)
        {
            _position = _initialPosition;
            _zoom = _initialZoom;
            _rotation = _initialRotation;
        }

        public void Update()
        {
            if (_currentStep < _tweenSteps)
            {
                switch (_tweenType)
                {
                    case TweenType.Linear:
                        _position = _positionFrom + (_positionGoto - _positionFrom) * GetLinear((float)_currentStep / _tweenSteps);
                        break;
                    case TweenType.QuadraticInOut:
                        _position = _positionFrom + (_positionGoto - _positionFrom) * GetQuadraticInOut((float)_currentStep / _tweenSteps);

                        break;
                    case TweenType.CubicInOut:
                        _position = _positionFrom + (_positionGoto - _positionFrom) * GetCubicInOut((float)_currentStep / _tweenSteps);

                        break;
                    case TweenType.QuarticOut:
                        _position = _positionFrom + (_positionGoto - _positionFrom) * GetQuarticOut((float)_currentStep / _tweenSteps);

                        break;
                }

                _currentStep++;
            }
            else
            {
                _position = _positionGoto;
            }
        }

        public float GetLinear(float t)
        {
            return t;
        }

        public float GetQuadraticInOut(float t)
        {
            return (t * t) / ((2 * t * t) - (2 * t) + 1);
        }

        public float GetCubicInOut(float t)
        {
            return (t * t * t) / ((3 * t * t) - (3 * t) + 1);
        }

        public float GetQuarticOut(float t)
        {
            return -((t - 1) * (t - 1) * (t - 1) * (t - 1)) + 1;
        }

        public void SetPosition(Vector2 _newPosition)
        {
            _positionFrom = _position;
            _position = _newPosition;
            _positionGoto = _newPosition;
            _tweenType = TweenType.Instant;
            _currentStep = 0;
            _tweenType = 0;
        }

        public void SetPosition(Vector2 _newPosition, TweenType type, int numSteps)
        {
            _position = _newPosition;
            _positionFrom = _newPosition;
            _positionGoto = _newPosition;
            _tweenType = TweenType.Instant;
            _currentStep = 0;
            _tweenType = 0;
        }

        public Vector2 ToWorld(Vector2 vector)
        {
            vector /= (float)_zoom;
            Vector2 dx = new Vector2((float)Math.Cos(_rotation), (float)Math.Sin(_rotation));
            Vector2 dy = new Vector2((float)Math.Cos(_rotation + MathHelper.PiOver2), (float)Math.Sin(_rotation + MathHelper.PiOver2));

            return (this.Position + dx * vector.X + dy * vector.Y);
        }

        public void ApplyTransform()
        {
            Matrix4 transform = Matrix4.Identity;

            transform = Matrix4.Mult(transform, Matrix4.CreateTranslation(-Position.X, -Position.Y, 0));
            transform = Matrix4.Mult(transform, Matrix4.CreateRotationZ((float)-_rotation));
            transform = Matrix4.Mult(transform, Matrix4.CreateScale((float)_zoom, (float)_zoom, 1.0f));

            GL.MultMatrix(ref transform);
        }
    }
}
