﻿
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{

// C++: class CascadeClassifier
//javadoc: CascadeClassifier
	public class CascadeClassifier : DisposableOpenCVObject
	{

		protected override void Dispose (bool disposing)
		{
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			
			try {
				
				if (disposing) {
				}
				
				if (IsEnabledDispose) {
					if (nativeObj != IntPtr.Zero)
						objdetect_CascadeClassifier_delete (nativeObj);
					nativeObj = IntPtr.Zero;
				}
				
			} finally {
				base.Dispose (disposing);
			}
			
			#else
			return;
			#endif
		}
		
		protected CascadeClassifier (IntPtr addr) : base(addr)
		{
		
		}
	
	
		//
		// C++:   CascadeClassifier()
		//
	
		//javadoc: CascadeClassifier::CascadeClassifier()
		public   CascadeClassifier ()
		{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			nativeObj = objdetect_CascadeClassifier_CascadeClassifier_10 ();
		
			return;
#else
return;
#endif
		}
	
	
		//
		// C++:   CascadeClassifier(String filename)
		//
	
		//javadoc: CascadeClassifier::CascadeClassifier(filename)
		public   CascadeClassifier (string filename)
		{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			nativeObj = objdetect_CascadeClassifier_CascadeClassifier_11 (filename);
		
			return;
#else
return;
#endif
		}
	
	
		//
		// C++:  bool load(String filename)
		//
	
		//javadoc: CascadeClassifier::load(filename)
		public  bool load (string filename)
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = objdetect_CascadeClassifier_load_10 (nativeObj, filename);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++:  bool empty()
		//
	
		//javadoc: CascadeClassifier::empty()
		public  bool empty ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = objdetect_CascadeClassifier_empty_10 (nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++:  bool read(FileNode node)
		//
	
		// Unknown type 'FileNode' (I), skipping the function
	
	
		//
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		//
	
		//javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors, flags, minSize, maxSize)
		public  void detectMultiScale (Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			objdetect_CascadeClassifier_detectMultiScale_10 (nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
		
			return;
#else
return;
#endif
		}
	
		//javadoc: CascadeClassifier::detectMultiScale(image, objects)
		public  void detectMultiScale (Mat image, MatOfRect objects)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			objdetect_CascadeClassifier_detectMultiScale_11 (nativeObj, image.nativeObj, objects_mat.nativeObj);
		
			return;
#else
return;
#endif
		}
	
	

	
	
		//
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		//
	
		//javadoc: CascadeClassifier::detectMultiScale(image, objects, numDetections, scaleFactor, minNeighbors, flags, minSize, maxSize)
		public  void detectMultiScale2 (Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();
			if (numDetections != null)
				numDetections.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			Mat numDetections_mat = numDetections;
			objdetect_CascadeClassifier_detectMultiScale2_10 (nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
		
			return;
#else
return;
#endif
		}
	
		//javadoc: CascadeClassifier::detectMultiScale(image, objects, numDetections)
		public  void detectMultiScale2 (Mat image, MatOfRect objects, MatOfInt numDetections)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();
			if (numDetections != null)
				numDetections.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			Mat numDetections_mat = numDetections;
			objdetect_CascadeClassifier_detectMultiScale2_11 (nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj);
		
			return;
#else
return;
#endif
		}

		//
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
		//
		
		//javadoc: CascadeClassifier::detectMultiScale(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags, minSize, maxSize, outputRejectLevels)
		public  void detectMultiScale3 (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();
			if (rejectLevels != null)
				rejectLevels.ThrowIfDisposed ();
			if (levelWeights != null)
				levelWeights.ThrowIfDisposed ();
			
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			Mat rejectLevels_mat = rejectLevels;
			Mat levelWeights_mat = levelWeights;
			objdetect_CascadeClassifier_detectMultiScale3_10 (nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);
			
			return;
			#else
			return;
			#endif
		}
		
		//javadoc: CascadeClassifier::detectMultiScale(image, objects, rejectLevels, levelWeights)
		public  void detectMultiScale3 (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
		{
			ThrowIfDisposed ();
			if (image != null)
				image.ThrowIfDisposed ();
			if (objects != null)
				objects.ThrowIfDisposed ();
			if (rejectLevels != null)
				rejectLevels.ThrowIfDisposed ();
			if (levelWeights != null)
				levelWeights.ThrowIfDisposed ();
			
			#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
			Mat objects_mat = objects;
			Mat rejectLevels_mat = rejectLevels;
			Mat levelWeights_mat = levelWeights;
			objdetect_CascadeClassifier_detectMultiScale3_11 (nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);
			
			return;
			#else
			return;
			#endif
		}
	
	
		//
		// C++:  bool isOldFormatCascade()
		//
	
		//javadoc: CascadeClassifier::isOldFormatCascade()
		public  bool isOldFormatCascade ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = objdetect_CascadeClassifier_isOldFormatCascade_10 (nativeObj);
		
			return retVal;
#else
return false;
#endif
		}
	
	
		//
		// C++:  Size getOriginalWindowSize()
		//
	
		//javadoc: CascadeClassifier::getOriginalWindowSize()
		public  Size getOriginalWindowSize ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			double[] tmpArray = new double[2];
			objdetect_CascadeClassifier_getOriginalWindowSize_10 (nativeObj, tmpArray);
			Size retVal = new Size (tmpArray);
		
			return retVal;
#else
return null;
#endif
		}
	
	
		//
		// C++:  int getFeatureType()
		//
	
		//javadoc: CascadeClassifier::getFeatureType()
		public  int getFeatureType ()
		{
			ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			int retVal = objdetect_CascadeClassifier_getFeatureType_10 (nativeObj);
		
			return retVal;
#else
return -1;
#endif
		}
	
	
		//
		// C++: static bool convert(String oldcascade, String newcascade)
		//
	
		//javadoc: CascadeClassifier::convert(oldcascade, newcascade)
		public static bool convert (string oldcascade, string newcascade)
		{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
			bool retVal = objdetect_CascadeClassifier_convert_10 (oldcascade, newcascade);
		
			return retVal;
#else
return false;
#endif
		}
	
	

	
	
		#if UNITY_IOS && !UNITY_EDITOR
		// C++:   CascadeClassifier()
		[DllImport("__Internal")]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10 ();
		
		// C++:   CascadeClassifier(String filename)
		[DllImport("__Internal")]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11 (string filename);
		
		// C++:  bool load(String filename)
		[DllImport("__Internal")]
		private static extern bool objdetect_CascadeClassifier_load_10 (IntPtr nativeObj, string filename);
		
		// C++:  bool empty()
		[DllImport("__Internal")]
		private static extern bool objdetect_CascadeClassifier_empty_10 (IntPtr nativeObj);
		
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
		
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);
		

		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale2_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
		
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale2_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj);

		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale3_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);
		
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale3_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);


		// C++:  bool isOldFormatCascade()
		[DllImport("__Internal")]
		private static extern bool objdetect_CascadeClassifier_isOldFormatCascade_10 (IntPtr nativeObj);
		
		// C++:  Size getOriginalWindowSize()
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_getOriginalWindowSize_10 (IntPtr nativeObj, double[] vals);
		
		// C++:  int getFeatureType()
		[DllImport("__Internal")]
		private static extern int objdetect_CascadeClassifier_getFeatureType_10 (IntPtr nativeObj);
		
		// C++: static bool convert(String oldcascade, String newcascade)
		[DllImport("__Internal")]
		private static extern bool objdetect_CascadeClassifier_convert_10 (string oldcascade, string newcascade);
		
		// native support for java finalize()
		[DllImport("__Internal")]
		private static extern void objdetect_CascadeClassifier_delete (IntPtr nativeObj);
#else
	
		// C++:   CascadeClassifier()
		[DllImport("opencvforunity")]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10 ();
	
		// C++:   CascadeClassifier(String filename)
		[DllImport("opencvforunity")]
		private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11 (string filename);
	
		// C++:  bool load(String filename)
		[DllImport("opencvforunity")]
		private static extern bool objdetect_CascadeClassifier_load_10 (IntPtr nativeObj, string filename);
	
		// C++:  bool empty()
		[DllImport("opencvforunity")]
		private static extern bool objdetect_CascadeClassifier_empty_10 (IntPtr nativeObj);
	
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);

		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);
	

		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale2_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);

		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale2_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj);
	
		// C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale3_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);
		
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_detectMultiScale3_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);


		// C++:  bool isOldFormatCascade()
		[DllImport("opencvforunity")]
		private static extern bool objdetect_CascadeClassifier_isOldFormatCascade_10 (IntPtr nativeObj);
	
		// C++:  Size getOriginalWindowSize()
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_getOriginalWindowSize_10 (IntPtr nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
	
		// C++:  int getFeatureType()
		[DllImport("opencvforunity")]
		private static extern int objdetect_CascadeClassifier_getFeatureType_10 (IntPtr nativeObj);
	
		// C++: static bool convert(String oldcascade, String newcascade)
		[DllImport("opencvforunity")]
		private static extern bool objdetect_CascadeClassifier_convert_10 (string oldcascade, string newcascade);
	
		// native support for java finalize()
		[DllImport("opencvforunity")]
		private static extern void objdetect_CascadeClassifier_delete (IntPtr nativeObj);
#endif
	
	}
}
