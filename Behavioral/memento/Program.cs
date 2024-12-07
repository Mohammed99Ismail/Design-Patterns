
public class Memento
{
    public class Canvas
    {
        public string Content { get; set; }
        public string Color { get; set; }
        public string Border { get; set; }

        public CanvasState Save(string content, string color, string border)
        {
            this.Content = content;
            this.Color = color;
            this.Border = border;
            
            return new CanvasState(content, color, border);
        }

        public void Restore(CanvasState state)
        {
            if (state == null) throw new ArgumentNullException(nameof(state));

            this.Content = state.Content;
            this.Color = state.Color;
            this.Border = state.Border;
        }

        public void GetCanvas()
        {
            Console.WriteLine($"{Content} , {Color} , {Border}");
        }
    }

    public class CanvasState
    {
        public string Content { get; set; }
        public string Color { get; set; }
        public string Border { get; set; }

        public CanvasState(string content, string color, string border)
        {
            Content = content;
            Color = color;
            Border = border;
        }
    }

    public class CanvasHistory
    {
        private readonly Stack<CanvasState> _undoStack = new Stack<CanvasState>();
        private readonly Stack<CanvasState> _redoStack = new Stack<CanvasState>();

        public void Save(CanvasState state)
        {
            _undoStack.Push(state);
            _redoStack.Clear();
        }

        public CanvasState Undo()
        {
            if (_undoStack.Count == 0) return null;
            
            var memento = _undoStack.Pop();
            _redoStack.Push(memento);
            return memento;
        }

        public CanvasState Redo()
        {
            if (_redoStack.Count == 0) return null;

            var memento = _redoStack.Pop();
            _undoStack.Push(memento);
            return memento;
        }
    }

    
    public class Program
    {
        public static void Main()
        {
            var canvas = new Canvas();
            var history = new CanvasHistory();

            history.Save(canvas.Save(content: "Circle", color: "Red", border: "Solid"));

            history.Save(canvas.Save(content: "Square", color: "Blue", border: "Dashed"));

            history.Save(canvas.Save(content: "Triangle", color: "Green", border: "Dotted"));
            // canvas.GetCanvas();

            canvas.Restore(history.Undo());
            canvas.GetCanvas();

            canvas.Restore(history.Undo());
            canvas.GetCanvas();

            canvas.Restore(history.Redo());
            canvas.GetCanvas();

            canvas.Restore(history.Redo());
            canvas.GetCanvas();
        }
    }
}
