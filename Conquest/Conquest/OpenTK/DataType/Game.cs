using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Conquest
{
    public class Game : GameWindow
    {
        Camera _camera;

        string ASSETS_PATH = Environment.CurrentDirectory + "\\Assets\\";

        public Game(int width, int height)
            : base(width, height)
        {
            GL.Enable(EnableCap.Texture2D);
            
            _camera = new Camera(Vector2.Zero, 1.0, 0.0);

            MouseDown += Mouse_ButtonDown;
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

            string[] paths = Directory.GetFiles(ASSETS_PATH);

            paths.ToList().ForEach((s) =>
            {
                KeyValuePair<string, Texture2D> pair = AssetManager.LoadTexture(s);

                AssetManager.AddTexture(pair.Key, pair.Value);
            });
            
            GameObject obj = new GameObject(AssetManager.GetTexture("Slot.PNG"), new Vector2(0, 0), new Vector2(1, 1), System.Drawing.Color.Transparent, new Vector2(0, 0));
            //DrawManager.AddToQueue(obj);

            Board board = new Board(3, 2);
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

            DrawManager.DrawQueue();

            this.SwapBuffers();
        }

        
    }
}
