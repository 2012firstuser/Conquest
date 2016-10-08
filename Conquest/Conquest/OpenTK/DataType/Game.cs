using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Game : GameWindow
    {
        Dictionary<string, Texture2D> _textures;
        List<GameObject> _drawQueue;
        Camera _camera;

        public Game(int width, int height)
            : base(width, height)
        {
            GL.Enable(EnableCap.Texture2D);

            _camera = new Camera(Vector2.Zero, 1.0, 0.0);

            Mouse.ButtonDown += Mouse_ButtonDown;
        }

        private void Mouse_ButtonDown(object sender, OpenTK.Input.MouseButtonEventArgs e)
        {
            Vector2 pos = new Vector2(e.Position.X, e.Position.Y);
            pos -= new Vector2(this.Width, this.Height) / 2f;
            pos = _camera.ToWorld(pos);

            _camera.SetPosition(pos, TweenType.QuarticOut, 60);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            throw new NotImplementedException("need to impl");
            KeyValuePair<string, Texture2D> pair = AssetManager.LoadTexture("");

            _textures.Add(pair.Key, pair.Value);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            _camera.Update();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);

            DrawManager.Begin(this.Width, this.Height);
            _camera.ApplyTransform();

            _drawQueue.ForEach((g) => { DrawManager.Draw(g.Texture2D, g.Position, g.Scale, g.Color, new Vector2(0, 0)); });

            this.SwapBuffers();
        }

        
    }
}
