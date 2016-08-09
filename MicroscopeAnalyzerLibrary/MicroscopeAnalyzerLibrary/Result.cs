using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmetrics;
using System.Runtime.InteropServices;

namespace MicroscopeAnalyzerLibrary
{
    [ComVisible(true)]
    public class Result
    {
        public string ret = "";


        public bool AlarmTriggered;
        public float GOF;
        public bool GofIsOK;
        public float[] LayerRoughnesses;
        public float[] LayerThicknesses;
        public float[] MeasFFTIntensity;
        public float[] MeasFFTThickness;
        public float[] PrimaryCalcSpectrum;
        public float[] PrimaryCalcWavelengths;
        public float[] PrimarySpectrum;
        public float[] PrimaryWavelengths;
        public string ResultsSummary;
        public float[] SpectrumAnalysisExtremaValues;
        public float[] SpectrumAnalysisExtremaWavelengthes;
        public float[] SpectrumAnalysisMeanValues;
        
        public Result()
        {
        }
        
        public Result(Filmetrics.FIRemote.FIMeasResults e)
        {
            this.AlarmTriggered = e.AlarmTriggered;
            this.GOF = e.GOF;
            this.GofIsOK = e.GofIsOK;
            this.LayerRoughnesses = e.LayerRoughnesses == null ? null : (float[])e.LayerRoughnesses.Clone();
            this.LayerThicknesses = e.LayerThicknesses == null ? null : (float[])e.LayerThicknesses.Clone();
            this.MeasFFTIntensity = e.MeasFFTIntensity == null ? null : (float[])e.MeasFFTIntensity.Clone();
            this.MeasFFTThickness = e.MeasFFTThickness == null ? null : (float[])e.MeasFFTThickness.Clone();
            this.PrimaryCalcSpectrum = e.PrimaryCalcSpectrum == null ? null : (float[])e.PrimaryCalcSpectrum.Clone();
            this.PrimaryCalcWavelengths = e.PrimaryCalcWavelengths == null ? null : (float[])e.PrimaryCalcWavelengths.Clone();
            this.PrimarySpectrum = e.PrimarySpectrum == null ? null : (float[])e.PrimarySpectrum.Clone();
            this.PrimaryWavelengths = e.PrimaryWavelengths == null ? null : (float[])e.PrimaryWavelengths.Clone();
            this.ResultsSummary = e.ResultsSummary == null ? null : String.Copy(e.ResultsSummary);
            this.SpectrumAnalysisExtremaValues = e.SpectrumAnalysisExtremaValues == null ? null : (float[])e.SpectrumAnalysisExtremaValues.Clone();
            this.SpectrumAnalysisExtremaWavelengthes = e.SpectrumAnalysisExtremaWavelengthes == null ? null : (float[])e.SpectrumAnalysisExtremaWavelengthes.Clone();
            this.SpectrumAnalysisMeanValues = e.SpectrumAnalysisMeanValues == null ? null : (float[])e.SpectrumAnalysisMeanValues.Clone();
        }

    }
}
