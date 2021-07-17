using System;
using State.Tools;

namespace State
{
    public class Canvas
    {
        private ITool _currentTool;

        public Canvas()
        {
            _currentTool = new Selection();
        }

        public Canvas(ITool defaultTool)
        {
            _currentTool = defaultTool;
        }
        
        public void MouseDown()
        {
            _currentTool.MouseDown();
        }

        public void MouseUp()
        {
            _currentTool.MouseUp();
        }

        public void EnableTool(ToolNames toolName)
        {
            _currentTool = toolName switch
            {
                ToolNames.Selection => new Selection(),
                ToolNames.Brush => new Brush(),
                ToolNames.Erase => new Erase(),
                _ => throw new ArgumentOutOfRangeException(nameof(toolName), toolName, null)
            };
        }
    }
}