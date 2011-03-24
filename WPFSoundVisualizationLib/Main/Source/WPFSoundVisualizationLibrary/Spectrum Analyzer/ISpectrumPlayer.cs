// Copyright (C) 2011, Jacob Johnston 
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

namespace WPFSoundVisualizationLib
{
    /// <summary>
    /// Provides access to sound player functionality needed to
    /// render a spectrum analyzer.
    /// </summary>
    public interface ISpectrumPlayer : ISoundPlayer
    {
        /// <summary>
        /// Assigns current FFT data to a buffer.
        /// </summary>
        /// <param name="fftDataBuffer">The buffer to copy FFT data</param>
        /// <returns>True if data was written to the buffer, otherwise false.</returns>
        bool GetFFTData(float[] fftDataBuffer);

        /// <summary>
        /// Gets the index in the FFT data buffer for a given frequency.
        /// </summary>
        /// <param name="frequency">The frequency for which to obtain a buffer index</param>
        /// <returns>An index in the FFT data buffer</returns>
        int GetFFTFrequencyIndex(int frequency);
    }
}
