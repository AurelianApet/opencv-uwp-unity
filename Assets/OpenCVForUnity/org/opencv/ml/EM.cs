﻿
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class EM
//javadoc: EM
	public class EM : StatModel
	{

		protected override void Dispose (bool disposing)
		{
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			
			try {
				
				if (disposing) {
				}
				
				if (IsEnabledDispose) {
					if (nativeObj != IntPtr.Zero)
						ml_EM_delete (nativeObj);
					nativeObj = IntPtr.Zero;
				}
				
			} finally {
				base.Dispose (disposing);
			}
			
			#else
			return;
			#endif
		}
		
		protected EM (IntPtr addr) : base(addr)
		{
		}
	
		public const int
			COV_MAT_SPHERICAL = 0,
			COV_MAT_DIAGONAL = 1,
			COV_MAT_GENERIC = 2,
			COV_MAT_DEFAULT = COV_MAT_DIAGONAL,
			DEFAULT_NCLUSTERS = 5,
			DEFAULT_MAX_ITERS = 100,
			START_E_STEP = 1,
			START_M_STEP = 2,
			START_AUTO_STEP = 0;
	
	
		//
		// C++:  int getClustersNumber()
		//
	
		//javadoc: EM::getClustersNumber()
		public  int getClustersNumber ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			int retVal = ml_EM_getClustersNumber_10 (nativeObj);
		
			return retVal;
#else
return -1;
#endif
		}
	
	
		//
		// C++:  void setClustersNumber(int val)
		//
	
		//javadoc: EM::setClustersNumber(val)
		public  void setClustersNumber (int val)
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			ml_EM_setClustersNumber_10 (nativeObj, val);
		
			return;
#else
return;
#endif
		}
	
	
		//
		// C++:  int getCovarianceMatrixType()
		//
	
		//javadoc: EM::getCovarianceMatrixType()
		public  int getCovarianceMatrixType ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			int retVal = ml_EM_getCovarianceMatrixType_10 (nativeObj);
		
			return retVal;
#else
return -1;
#endif
		}
	
	
		//
		// C++:  void setCovarianceMatrixType(int val)
		//
	
		//javadoc: EM::setCovarianceMatrixType(val)
		public  void setCovarianceMatrixType (int val)
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			ml_EM_setCovarianceMatrixType_10 (nativeObj, val);
		
			return;
#else
return;
#endif
		}
	
	
		//
		// C++:  TermCriteria getTermCriteria()
		//
	
		//javadoc: EM::getTermCriteria()
		public  TermCriteria getTermCriteria ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			double[] tmpArray = new double[3];
			ml_EM_getTermCriteria_10 (nativeObj, tmpArray);
			TermCriteria retVal = new TermCriteria (tmpArray);
		
			return retVal;
#else
return null;
#endif
		}
	
	
		//
		// C++:  void setTermCriteria(TermCriteria val)
		//
	
		//javadoc: EM::setTermCriteria(val)
		public  void setTermCriteria (TermCriteria val)
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			ml_EM_setTermCriteria_10 (nativeObj, val.type, val.maxCount, val.epsilon);
		
			return;
#else
return;
#endif
		}
	
	
		//
		// C++:  Mat getWeights()
		//
	
		//javadoc: EM::getWeights()
		public  Mat getWeights ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			Mat retVal = new Mat (ml_EM_getWeights_10 (nativeObj));
		
			return retVal;
#else
return null;
#endif
		}
	
	
		//
		// C++:  Mat getMeans()
		//
	
		//javadoc: EM::getMeans()
		public  Mat getMeans ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			Mat retVal = new Mat (ml_EM_getMeans_10 (nativeObj));
		
			return retVal;
#else
return null;
#endif
		}
	
	
		//
		// C++:  Vec2d predict2(Mat sample, Mat& probs)
		//
	
		//javadoc: EM::predict2(sample, probs)
		public  double[] predict2 (Mat sample, Mat probs)
		{
			ThrowIfDisposed ();
			if (sample != null)
				sample.ThrowIfDisposed ();
			if (probs != null)
				probs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			double[] retVal = new double[2];
			ml_EM_predict2_10 (nativeObj, sample.nativeObj, probs.nativeObj, retVal);
		
			return retVal;
#else
return null;
#endif
		}
	
	
		//
		// C++:  bool trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		//
	
		//javadoc: EM::trainEM(samples, logLikelihoods, labels, probs)
		public  bool trainEM (Mat samples, Mat logLikelihoods, Mat labels, Mat probs)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();
			if (logLikelihoods != null)
				logLikelihoods.ThrowIfDisposed ();
			if (labels != null)
				labels.ThrowIfDisposed ();
			if (probs != null)
				probs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainEM_10 (nativeObj, samples.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
		//javadoc: EM::trainEM(samples)
		public  bool trainEM (Mat samples)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainEM_11 (nativeObj, samples.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++:  bool trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		//
	
		//javadoc: EM::trainE(samples, means0, covs0, weights0, logLikelihoods, labels, probs)
		public  bool trainE (Mat samples, Mat means0, Mat covs0, Mat weights0, Mat logLikelihoods, Mat labels, Mat probs)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();
			if (means0 != null)
				means0.ThrowIfDisposed ();
			if (covs0 != null)
				covs0.ThrowIfDisposed ();
			if (weights0 != null)
				weights0.ThrowIfDisposed ();
			if (logLikelihoods != null)
				logLikelihoods.ThrowIfDisposed ();
			if (labels != null)
				labels.ThrowIfDisposed ();
			if (probs != null)
				probs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainE_10 (nativeObj, samples.nativeObj, means0.nativeObj, covs0.nativeObj, weights0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
		//javadoc: EM::trainE(samples, means0)
		public  bool trainE (Mat samples, Mat means0)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();
			if (means0 != null)
				means0.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainE_11 (nativeObj, samples.nativeObj, means0.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++:  bool trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		//
	
		//javadoc: EM::trainM(samples, probs0, logLikelihoods, labels, probs)
		public  bool trainM (Mat samples, Mat probs0, Mat logLikelihoods, Mat labels, Mat probs)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();
			if (probs0 != null)
				probs0.ThrowIfDisposed ();
			if (logLikelihoods != null)
				logLikelihoods.ThrowIfDisposed ();
			if (labels != null)
				labels.ThrowIfDisposed ();
			if (probs != null)
				probs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainM_10 (nativeObj, samples.nativeObj, probs0.nativeObj, logLikelihoods.nativeObj, labels.nativeObj, probs.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
		//javadoc: EM::trainM(samples, probs0)
		public  bool trainM (Mat samples, Mat probs0)
		{
			ThrowIfDisposed ();
			if (samples != null)
				samples.ThrowIfDisposed ();
			if (probs0 != null)
				probs0.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = ml_EM_trainM_11 (nativeObj, samples.nativeObj, probs0.nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++: static Ptr_EM create()
		//
	
		//javadoc: EM::create()
		public static EM create ()
		{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			EM retVal = new EM (ml_EM_create_10 ());
		
			return retVal;
#else
return null;
#endif
		}
	
	

	
		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  int getClustersNumber()
		[DllImport("__Internal")]
		private static extern int ml_EM_getClustersNumber_10 (IntPtr nativeObj);
		
		// C++:  void setClustersNumber(int val)
		[DllImport("__Internal")]
		private static extern void ml_EM_setClustersNumber_10 (IntPtr nativeObj, int val);
		
		// C++:  int getCovarianceMatrixType()
		[DllImport("__Internal")]
		private static extern int ml_EM_getCovarianceMatrixType_10 (IntPtr nativeObj);
		
		// C++:  void setCovarianceMatrixType(int val)
		[DllImport("__Internal")]
		private static extern void ml_EM_setCovarianceMatrixType_10 (IntPtr nativeObj, int val);
		
		// C++:  TermCriteria getTermCriteria()
		[DllImport("__Internal")]
		private static extern void ml_EM_getTermCriteria_10 (IntPtr nativeObj, double[] vals);
		
		// C++:  void setTermCriteria(TermCriteria val)
		[DllImport("__Internal")]
		private static extern void ml_EM_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);
		
		// C++:  Mat getWeights()
		[DllImport("__Internal")]
		private static extern IntPtr ml_EM_getWeights_10 (IntPtr nativeObj);
		
		// C++:  Mat getMeans()
		[DllImport("__Internal")]
		private static extern IntPtr ml_EM_getMeans_10 (IntPtr nativeObj);
		
		// C++:  Vec2d predict2(Mat sample, Mat& probs)
		[DllImport("__Internal")]
		private static extern void ml_EM_predict2_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr probs_nativeObj, double[] vals);
		
		// C++:  bool trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainEM_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
		
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainEM_11 (IntPtr nativeObj, IntPtr samples_nativeObj);
		
		// C++:  bool trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainE_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
		
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainE_11 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj);
		
		// C++:  bool trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainM_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);
		
		[DllImport("__Internal")]
		private static extern bool ml_EM_trainM_11 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj);
		
		// C++: static Ptr_EM create()
		[DllImport("__Internal")]
		private static extern IntPtr ml_EM_create_10 ();
		
		// native support for java finalize()
		[DllImport("__Internal")]
		private static extern void ml_EM_delete (IntPtr nativeObj);
#else
	
		// C++:  int getClustersNumber()
		[DllImport("opencvforunity")]
		private static extern int ml_EM_getClustersNumber_10 (IntPtr nativeObj);
	
		// C++:  void setClustersNumber(int val)
		[DllImport("opencvforunity")]
		private static extern void ml_EM_setClustersNumber_10 (IntPtr nativeObj, int val);
	
		// C++:  int getCovarianceMatrixType()
		[DllImport("opencvforunity")]
		private static extern int ml_EM_getCovarianceMatrixType_10 (IntPtr nativeObj);
	
		// C++:  void setCovarianceMatrixType(int val)
		[DllImport("opencvforunity")]
		private static extern void ml_EM_setCovarianceMatrixType_10 (IntPtr nativeObj, int val);
	
		// C++:  TermCriteria getTermCriteria()
		[DllImport("opencvforunity")]
		private static extern void ml_EM_getTermCriteria_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] double[] vals);
	
		// C++:  void setTermCriteria(TermCriteria val)
		[DllImport("opencvforunity")]
		private static extern void ml_EM_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);
	
		// C++:  Mat getWeights()
		[DllImport("opencvforunity")]
		private static extern IntPtr ml_EM_getWeights_10 (IntPtr nativeObj);
	
		// C++:  Mat getMeans()
		[DllImport("opencvforunity")]
		private static extern IntPtr ml_EM_getMeans_10 (IntPtr nativeObj);
	
		// C++:  Vec2d predict2(Mat sample, Mat& probs)
		[DllImport("opencvforunity")]
		private static extern void ml_EM_predict2_10 (IntPtr nativeObj, IntPtr sample_nativeObj, IntPtr probs_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
	
		// C++:  bool trainEM(Mat samples, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainEM_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainEM_11 (IntPtr nativeObj, IntPtr samples_nativeObj);
	
		// C++:  bool trainE(Mat samples, Mat means0, Mat covs0 = Mat(), Mat weights0 = Mat(), Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainE_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj, IntPtr covs0_nativeObj, IntPtr weights0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainE_11 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr means0_nativeObj);
	
		// C++:  bool trainM(Mat samples, Mat probs0, Mat& logLikelihoods = Mat(), Mat& labels = Mat(), Mat& probs = Mat())
		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainM_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj, IntPtr logLikelihoods_nativeObj, IntPtr labels_nativeObj, IntPtr probs_nativeObj);

		[DllImport("opencvforunity")]
		private static extern bool ml_EM_trainM_11 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr probs0_nativeObj);
	
		// C++: static Ptr_EM create()
		[DllImport("opencvforunity")]
		private static extern IntPtr ml_EM_create_10 ();
	
		// native support for java finalize()
		[DllImport("opencvforunity")]
		private static extern void ml_EM_delete (IntPtr nativeObj);
#endif
	
	}
}
