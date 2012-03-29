// Copyright (C) 2011 - 2012, Jacob Johnston 
//
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions: 
//
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software. 
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE. 

using System.Windows;

namespace WPFSoundVisualizationLib
{
    /// <summary>
    /// Provides data for the time editor change events. 
    /// </summary>
    public sealed class TimeEditorEventArgs : RoutedEventArgs
    {
        /// <summary>
        /// The action performed on the TimeEditor.
        /// </summary>
        public TimeEditorAction Action { get; private set; }

        /// <summary>
        /// The field on which the <see cref="Action" /> is performed
        /// </summary>
        public TimeEditorField ActiveField { get; private set; }
                
        /// <summary>
        /// Initializes a new instance of the TimeEditorEventArgs class.
        /// </summary>
        /// <param name="action">The action performed on the TimeEditor</param>
        /// <param name="activeField">The field on which the action was performed.</param>
        public TimeEditorEventArgs(TimeEditorAction action, TimeEditorField activeField)
        {
            Action = action;
            ActiveField = activeField;
        }
        
        /// <summary>
        /// Initializes a new instance of the TimeEditorEventArgs class, using the supplied routed event identifier.
        /// </summary>
        /// <param name="routedEvent">The routed event identifier for this instance of the RoutedEventArgs class.</param>
        /// <param name="action">The action performed on the TimeEditor</param>
        /// <param name="activeField">The field on which the action was performed.</param>
        public TimeEditorEventArgs(RoutedEvent routedEvent, TimeEditorAction action, TimeEditorField activeField)
            : base(routedEvent)
        {
            Action = action;
            ActiveField = activeField;
        }
        
        /// <summary>
        /// Initializes a new instance of the TimeEditorEventArgs class, using the supplied routed event identifier, and
        /// providing the opportunity to declar a different source for the event.
        /// </summary>
        /// <param name="routedEvent">The routed event identifier for this instance of the RoutedEventArgs class.</param>
        /// <param name="source">An alternate source that will be reported when the event is handled. This
        /// pre-populates the RoutedEventArgs.Source property.</param>
        /// <param name="action">The action performed on the TimeEditor</param>
        /// <param name="activeField">The field on which the action was performed.</param>
        public TimeEditorEventArgs(RoutedEvent routedEvent, object source, TimeEditorAction action, TimeEditorField activeField)
            : base(routedEvent, source)
        {
            Action = action;
            ActiveField = activeField;
        }
    }
}
