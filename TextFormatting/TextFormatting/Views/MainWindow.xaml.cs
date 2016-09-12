using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using TextFormatting.DesktopClient.ViewModels;

namespace TextFormatting.DesktopClient.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tag> m_tags = new List<Tag>();
      
        public MainWindow()
        {
            InitializeComponent();
            rtb_UserText.Document.Blocks.Clear();
        }

        private void rtb_UserText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (rtb_UserText.Document == null)
                return;

            TextRange documentRange = new TextRange(rtb_UserText.Document.ContentStart, rtb_UserText.Document.ContentEnd);
            documentRange.ClearAllProperties();

            TextPointer navigator = rtb_UserText.Document.ContentStart;
            while (navigator.CompareTo(rtb_UserText.Document.ContentEnd) < 0)
            {
                TextPointerContext context = navigator.GetPointerContext(LogicalDirection.Backward);
                if (context == TextPointerContext.ElementStart && navigator.Parent is Run)
                {
                    CheckWordsInRun((Run)navigator.Parent);

                }
                navigator = navigator.GetNextContextPosition(LogicalDirection.Forward);
            }

            Format();
        }

        new struct Tag
        {
            public TextPointer StartPosition;
            public TextPointer EndPosition;
            public string Word;

        }

        void CheckWordsInRun(Run run)
        {
            try
            {
                #region "Try"

                string text = run.Text;
                int sIndex = 0;
                int eIndex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (Char.IsWhiteSpace(text[i]))
                    {
                        if (i > 0 && !(Char.IsWhiteSpace(text[i - 1])))
                        {
                            eIndex = i - 1;
                            string word = text.Substring(sIndex, eIndex - sIndex + 1);

                            if (FormatSyntax.IsKnownTag(word))
                            {
                                Tag t = new Tag();
                                t.StartPosition = run.ContentStart.GetPositionAtOffset(sIndex, LogicalDirection.Forward);
                                t.EndPosition = run.ContentStart.GetPositionAtOffset(eIndex + 1, LogicalDirection.Backward);
                                t.Word = word;
                                m_tags.Add(t);
                            }
                        }
                        sIndex = i + 1;
                    }
                }

                string lastWord = text.Substring(sIndex, text.Length - sIndex);
                if (FormatSyntax.IsKnownTag(lastWord))
                {
                    Tag t = new Tag();
                    t.StartPosition = run.ContentStart.GetPositionAtOffset(sIndex, LogicalDirection.Forward);
                    t.EndPosition = run.ContentStart.GetPositionAtOffset(eIndex + 1, LogicalDirection.Backward);
                    t.Word = lastWord;
                    m_tags.Add(t);
                }

                //if (FormatSyntax.IsHashSymbol(lastWord))
                //{
                //    Tag t = new Tag();
                //    t.StartPosition = run.ContentStart.GetPositionAtOffset(sIndex+1, LogicalDirection.Forward);
                //    t.EndPosition = run.ContentStart.GetPositionAtOffset(eIndex + 1, LogicalDirection.Backward);
                //    t.Word = lastWord;
                //    m_tags.Add(t);
                //}
                #endregion
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in TextFormatting.DesktopClient.Views.MainWindow.CheckWordsInRun(Run run) :" + ex.Message);
            }
           
        }

        void Format()
        {
            try
            {
                rtb_UserText.TextChanged -= this.rtb_UserText_TextChanged;

                for (int i = 0; i < m_tags.Count; i++)
                {
                    TextRange range = new TextRange(m_tags[i].StartPosition, m_tags[i].EndPosition);
                    range.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Colors.Red));
                    range.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                }
                m_tags.Clear();

                rtb_UserText.TextChanged += this.rtb_UserText_TextChanged;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in TextFormatting.DesktopClient.Views.MainWindow.Format() :" + ex.Message);
            }
           
        }

    }
}
