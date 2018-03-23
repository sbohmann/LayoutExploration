using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExploration
{
    class MainWindow : Window
    {
        const double Gap = 5.0;
        const int ButtonWidth = 70;
        const int ButtonHeight = 50;

        Canvas canvas;
        TextBox display;
        List<Button> numberButtons;
        decimal value = 0;

        internal MainWindow()
        {
            Content = canvas = new Canvas();
            display = new TextBox();
            createNumberButtons();
        }

        void createNumberButtons()
        {
           numberButtons = new List<Button>();
            for (int value = 0; value <= 9; ++value)
            {
                addNumberButton(createNumberButton(value));
            }
        }

        private void addNumberButton(Button button)
        {
            numberButtons.Add(button);
            canvas.Children.Add(button);
        }

        Button createNumberButton(int value)
        {
            var result = new Button();
            result.Content = value.ToString();
            layoutNumberButton(value, result);
            return result;
        }

        void layoutNumberButton(int value, Button button)
        {
            int gridX = NumberButtonGridPositions.CalculateGridX(value);
            int gridY = NumberButtonGridPositions.CalculateGridY(value);

            layoutButtonInGrid(button, gridX, gridY);
        }

        private void layoutButtonInGrid(Button button, int gridX, int gridY)
        {
            button.Width = ButtonWidth;
            button.Height = ButtonHeight;

            double x = Gap * (gridX + 1) + ButtonWidth * gridX;
            double y = Gap * (gridY + 1) + ButtonHeight * gridY;

            button.SetValue(Canvas.LeftProperty, x);
            button.SetValue(Canvas.TopProperty, y);
        }

        void updateDisplay()
        {
            display.Text = value.ToString();
        }
    }
}
