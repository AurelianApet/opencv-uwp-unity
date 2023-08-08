﻿
//
// This file is auto-generated. Please don't modify it!
//
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace OpenCVForUnity
{
		public class Imgproc
		{
	
				private const int
						IPL_BORDER_CONSTANT = 0,
						IPL_BORDER_REPLICATE = 1,
						IPL_BORDER_REFLECT = 2,
						IPL_BORDER_WRAP = 3,
						IPL_BORDER_REFLECT_101 = 4,
						IPL_BORDER_TRANSPARENT = 5,
						CV_INTER_NN = 0,
						CV_INTER_LINEAR = 1,
						CV_INTER_CUBIC = 2,
						CV_INTER_AREA = 3,
						CV_INTER_LANCZOS4 = 4,
						CV_MOP_ERODE = 0,
						CV_MOP_DILATE = 1,
						CV_MOP_OPEN = 2,
						CV_MOP_CLOSE = 3,
						CV_MOP_GRADIENT = 4,
						CV_MOP_TOPHAT = 5,
						CV_MOP_BLACKHAT = 6,
						CV_RETR_EXTERNAL = 0,
						CV_RETR_LIST = 1,
						CV_RETR_CCOMP = 2,
						CV_RETR_TREE = 3,
						CV_RETR_FLOODFILL = 4,
						CV_CHAIN_APPROX_NONE = 1,
						CV_CHAIN_APPROX_SIMPLE = 2,
						CV_CHAIN_APPROX_TC89_L1 = 3,
						CV_CHAIN_APPROX_TC89_KCOS = 4,
						CV_THRESH_BINARY = 0,
						CV_THRESH_BINARY_INV = 1,
						CV_THRESH_TRUNC = 2,
						CV_THRESH_TOZERO = 3,
						CV_THRESH_TOZERO_INV = 4,
						CV_THRESH_MASK = 7,
						CV_THRESH_OTSU = 8,
						CV_THRESH_TRIANGLE = 16;
				public const int
						LINE_AA = 16,
						LINE_8 = 8,
						LINE_4 = 4,
						CV_BLUR_NO_SCALE = 0,
						CV_BLUR = 1,
						CV_GAUSSIAN = 2,
						CV_MEDIAN = 3,
						CV_BILATERAL = 4,
						CV_GAUSSIAN_5x5 = 7,
						CV_SCHARR = -1,
						CV_MAX_SOBEL_KSIZE = 7,
						CV_RGBA2mRGBA = 125,
						CV_mRGBA2RGBA = 126,
						CV_WARP_FILL_OUTLIERS = 8,
						CV_WARP_INVERSE_MAP = 16,
						CV_SHAPE_RECT = 0,
						CV_SHAPE_CROSS = 1,
						CV_SHAPE_ELLIPSE = 2,
						CV_SHAPE_CUSTOM = 100,
						CV_CHAIN_CODE = 0,
						CV_LINK_RUNS = 5,
						CV_POLY_APPROX_DP = 0,
						CV_CONTOURS_MATCH_I1 = 1,
						CV_CONTOURS_MATCH_I2 = 2,
						CV_CONTOURS_MATCH_I3 = 3,
						CV_CLOCKWISE = 1,
						CV_COUNTER_CLOCKWISE = 2,
						CV_COMP_CORREL = 0,
						CV_COMP_CHISQR = 1,
						CV_COMP_INTERSECT = 2,
						CV_COMP_BHATTACHARYYA = 3,
						CV_COMP_HELLINGER = CV_COMP_BHATTACHARYYA,
						CV_COMP_CHISQR_ALT = 4,
						CV_COMP_KL_DIV = 5,
						CV_DIST_MASK_3 = 3,
						CV_DIST_MASK_5 = 5,
						CV_DIST_MASK_PRECISE = 0,
						CV_DIST_LABEL_CCOMP = 0,
						CV_DIST_LABEL_PIXEL = 1,
						CV_DIST_USER = -1,
						CV_DIST_L1 = 1,
						CV_DIST_L2 = 2,
						CV_DIST_C = 3,
						CV_DIST_L12 = 4,
						CV_DIST_FAIR = 5,
						CV_DIST_WELSCH = 6,
						CV_DIST_HUBER = 7,
						CV_CANNY_L2_GRADIENT = (1 << 31),
						CV_HOUGH_STANDARD = 0,
						CV_HOUGH_PROBABILISTIC = 1,
						CV_HOUGH_MULTI_SCALE = 2,
						CV_HOUGH_GRADIENT = 3,
						MORPH_ERODE = 0,
						MORPH_DILATE = 1,
						MORPH_OPEN = 2,
						MORPH_CLOSE = 3,
						MORPH_GRADIENT = 4,
						MORPH_TOPHAT = 5,
						MORPH_BLACKHAT = 6,
						MORPH_RECT = 0,
						MORPH_CROSS = 1,
						MORPH_ELLIPSE = 2,
						INTER_NEAREST = 0,
						INTER_LINEAR = 1,
						INTER_CUBIC = 2,
						INTER_AREA = 3,
						INTER_LANCZOS4 = 4,
						INTER_MAX = 7,
						WARP_FILL_OUTLIERS = 8,
						WARP_INVERSE_MAP = 16,
						INTER_BITS = 5,
						INTER_BITS2 = INTER_BITS * 2,
						INTER_TAB_SIZE = 1 << INTER_BITS,
						INTER_TAB_SIZE2 = INTER_TAB_SIZE * INTER_TAB_SIZE,
						DIST_USER = -1,
						DIST_L1 = 1,
						DIST_L2 = 2,
						DIST_C = 3,
						DIST_L12 = 4,
						DIST_FAIR = 5,
						DIST_WELSCH = 6,
						DIST_HUBER = 7,
						DIST_MASK_3 = 3,
						DIST_MASK_5 = 5,
						DIST_MASK_PRECISE = 0,
						THRESH_BINARY = 0,
						THRESH_BINARY_INV = 1,
						THRESH_TRUNC = 2,
						THRESH_TOZERO = 3,
						THRESH_TOZERO_INV = 4,
						THRESH_MASK = 7,
						THRESH_OTSU = 8,
						THRESH_TRIANGLE = 16,
						ADAPTIVE_THRESH_MEAN_C = 0,
						ADAPTIVE_THRESH_GAUSSIAN_C = 1,
						PROJ_SPHERICAL_ORTHO = 0,
						PROJ_SPHERICAL_EQRECT = 1,
						GC_BGD = 0,
						GC_FGD = 1,
						GC_PR_BGD = 2,
						GC_PR_FGD = 3,
						GC_INIT_WITH_RECT = 0,
						GC_INIT_WITH_MASK = 1,
						GC_EVAL = 2,
						DIST_LABEL_CCOMP = 0,
						DIST_LABEL_PIXEL = 1,
						FLOODFILL_FIXED_RANGE = 1 << 16,
						FLOODFILL_MASK_ONLY = 1 << 17,
						CC_STAT_LEFT = 0,
						CC_STAT_TOP = 1,
						CC_STAT_WIDTH = 2,
						CC_STAT_HEIGHT = 3,
						CC_STAT_AREA = 4,
						CC_STAT_MAX = 5,
						RETR_EXTERNAL = 0,
						RETR_LIST = 1,
						RETR_CCOMP = 2,
						RETR_TREE = 3,
						RETR_FLOODFILL = 4,
						CHAIN_APPROX_NONE = 1,
						CHAIN_APPROX_SIMPLE = 2,
						CHAIN_APPROX_TC89_L1 = 3,
						CHAIN_APPROX_TC89_KCOS = 4,
						HOUGH_STANDARD = 0,
						HOUGH_PROBABILISTIC = 1,
						HOUGH_MULTI_SCALE = 2,
						HOUGH_GRADIENT = 3,
						LSD_REFINE_NONE = 0,
						LSD_REFINE_STD = 1,
						LSD_REFINE_ADV = 2,
						HISTCMP_CORREL = 0,
						HISTCMP_CHISQR = 1,
						HISTCMP_INTERSECT = 2,
						HISTCMP_BHATTACHARYYA = 3,
						HISTCMP_HELLINGER = HISTCMP_BHATTACHARYYA,
						HISTCMP_CHISQR_ALT = 4,
						HISTCMP_KL_DIV = 5,
						COLOR_BGR2BGRA = 0,
						COLOR_RGB2RGBA = COLOR_BGR2BGRA,
						COLOR_BGRA2BGR = 1,
						COLOR_RGBA2RGB = COLOR_BGRA2BGR,
						COLOR_BGR2RGBA = 2,
						COLOR_RGB2BGRA = COLOR_BGR2RGBA,
						COLOR_RGBA2BGR = 3,
						COLOR_BGRA2RGB = COLOR_RGBA2BGR,
						COLOR_BGR2RGB = 4,
						COLOR_RGB2BGR = COLOR_BGR2RGB,
						COLOR_BGRA2RGBA = 5,
						COLOR_RGBA2BGRA = COLOR_BGRA2RGBA,
						COLOR_BGR2GRAY = 6,
						COLOR_RGB2GRAY = 7,
						COLOR_GRAY2BGR = 8,
						COLOR_GRAY2RGB = COLOR_GRAY2BGR,
						COLOR_GRAY2BGRA = 9,
						COLOR_GRAY2RGBA = COLOR_GRAY2BGRA,
						COLOR_BGRA2GRAY = 10,
						COLOR_RGBA2GRAY = 11,
						COLOR_BGR2BGR565 = 12,
						COLOR_RGB2BGR565 = 13,
						COLOR_BGR5652BGR = 14,
						COLOR_BGR5652RGB = 15,
						COLOR_BGRA2BGR565 = 16,
						COLOR_RGBA2BGR565 = 17,
						COLOR_BGR5652BGRA = 18,
						COLOR_BGR5652RGBA = 19,
						COLOR_GRAY2BGR565 = 20,
						COLOR_BGR5652GRAY = 21,
						COLOR_BGR2BGR555 = 22,
						COLOR_RGB2BGR555 = 23,
						COLOR_BGR5552BGR = 24,
						COLOR_BGR5552RGB = 25,
						COLOR_BGRA2BGR555 = 26,
						COLOR_RGBA2BGR555 = 27,
						COLOR_BGR5552BGRA = 28,
						COLOR_BGR5552RGBA = 29,
						COLOR_GRAY2BGR555 = 30,
						COLOR_BGR5552GRAY = 31,
						COLOR_BGR2XYZ = 32,
						COLOR_RGB2XYZ = 33,
						COLOR_XYZ2BGR = 34,
						COLOR_XYZ2RGB = 35,
						COLOR_BGR2YCrCb = 36,
						COLOR_RGB2YCrCb = 37,
						COLOR_YCrCb2BGR = 38,
						COLOR_YCrCb2RGB = 39,
						COLOR_BGR2HSV = 40,
						COLOR_RGB2HSV = 41,
						COLOR_BGR2Lab = 44,
						COLOR_RGB2Lab = 45,
						COLOR_BGR2Luv = 50,
						COLOR_RGB2Luv = 51,
						COLOR_BGR2HLS = 52,
						COLOR_RGB2HLS = 53,
						COLOR_HSV2BGR = 54,
						COLOR_HSV2RGB = 55,
						COLOR_Lab2BGR = 56,
						COLOR_Lab2RGB = 57,
						COLOR_Luv2BGR = 58,
						COLOR_Luv2RGB = 59,
						COLOR_HLS2BGR = 60,
						COLOR_HLS2RGB = 61,
						COLOR_BGR2HSV_FULL = 66,
						COLOR_RGB2HSV_FULL = 67,
						COLOR_BGR2HLS_FULL = 68,
						COLOR_RGB2HLS_FULL = 69,
						COLOR_HSV2BGR_FULL = 70,
						COLOR_HSV2RGB_FULL = 71,
						COLOR_HLS2BGR_FULL = 72,
						COLOR_HLS2RGB_FULL = 73,
						COLOR_LBGR2Lab = 74,
						COLOR_LRGB2Lab = 75,
						COLOR_LBGR2Luv = 76,
						COLOR_LRGB2Luv = 77,
						COLOR_Lab2LBGR = 78,
						COLOR_Lab2LRGB = 79,
						COLOR_Luv2LBGR = 80,
						COLOR_Luv2LRGB = 81,
						COLOR_BGR2YUV = 82,
						COLOR_RGB2YUV = 83,
						COLOR_YUV2BGR = 84,
						COLOR_YUV2RGB = 85,
						COLOR_YUV2RGB_NV12 = 90,
						COLOR_YUV2BGR_NV12 = 91,
						COLOR_YUV2RGB_NV21 = 92,
						COLOR_YUV2BGR_NV21 = 93,
						COLOR_YUV420sp2RGB = COLOR_YUV2RGB_NV21,
						COLOR_YUV420sp2BGR = COLOR_YUV2BGR_NV21,
						COLOR_YUV2RGBA_NV12 = 94,
						COLOR_YUV2BGRA_NV12 = 95,
						COLOR_YUV2RGBA_NV21 = 96,
						COLOR_YUV2BGRA_NV21 = 97,
						COLOR_YUV420sp2RGBA = COLOR_YUV2RGBA_NV21,
						COLOR_YUV420sp2BGRA = COLOR_YUV2BGRA_NV21,
						COLOR_YUV2RGB_YV12 = 98,
						COLOR_YUV2BGR_YV12 = 99,
						COLOR_YUV2RGB_IYUV = 100,
						COLOR_YUV2BGR_IYUV = 101,
						COLOR_YUV2RGB_I420 = COLOR_YUV2RGB_IYUV,
						COLOR_YUV2BGR_I420 = COLOR_YUV2BGR_IYUV,
						COLOR_YUV420p2RGB = COLOR_YUV2RGB_YV12,
						COLOR_YUV420p2BGR = COLOR_YUV2BGR_YV12,
						COLOR_YUV2RGBA_YV12 = 102,
						COLOR_YUV2BGRA_YV12 = 103,
						COLOR_YUV2RGBA_IYUV = 104,
						COLOR_YUV2BGRA_IYUV = 105,
						COLOR_YUV2RGBA_I420 = COLOR_YUV2RGBA_IYUV,
						COLOR_YUV2BGRA_I420 = COLOR_YUV2BGRA_IYUV,
						COLOR_YUV420p2RGBA = COLOR_YUV2RGBA_YV12,
						COLOR_YUV420p2BGRA = COLOR_YUV2BGRA_YV12,
						COLOR_YUV2GRAY_420 = 106,
						COLOR_YUV2GRAY_NV21 = COLOR_YUV2GRAY_420,
						COLOR_YUV2GRAY_NV12 = COLOR_YUV2GRAY_420,
						COLOR_YUV2GRAY_YV12 = COLOR_YUV2GRAY_420,
						COLOR_YUV2GRAY_IYUV = COLOR_YUV2GRAY_420,
						COLOR_YUV2GRAY_I420 = COLOR_YUV2GRAY_420,
						COLOR_YUV420sp2GRAY = COLOR_YUV2GRAY_420,
						COLOR_YUV420p2GRAY = COLOR_YUV2GRAY_420,
						COLOR_YUV2RGB_UYVY = 107,
						COLOR_YUV2BGR_UYVY = 108,
						COLOR_YUV2RGB_Y422 = COLOR_YUV2RGB_UYVY,
						COLOR_YUV2BGR_Y422 = COLOR_YUV2BGR_UYVY,
						COLOR_YUV2RGB_UYNV = COLOR_YUV2RGB_UYVY,
						COLOR_YUV2BGR_UYNV = COLOR_YUV2BGR_UYVY,
						COLOR_YUV2RGBA_UYVY = 111,
						COLOR_YUV2BGRA_UYVY = 112,
						COLOR_YUV2RGBA_Y422 = COLOR_YUV2RGBA_UYVY,
						COLOR_YUV2BGRA_Y422 = COLOR_YUV2BGRA_UYVY,
						COLOR_YUV2RGBA_UYNV = COLOR_YUV2RGBA_UYVY,
						COLOR_YUV2BGRA_UYNV = COLOR_YUV2BGRA_UYVY,
						COLOR_YUV2RGB_YUY2 = 115,
						COLOR_YUV2BGR_YUY2 = 116,
						COLOR_YUV2RGB_YVYU = 117,
						COLOR_YUV2BGR_YVYU = 118,
						COLOR_YUV2RGB_YUYV = COLOR_YUV2RGB_YUY2,
						COLOR_YUV2BGR_YUYV = COLOR_YUV2BGR_YUY2,
						COLOR_YUV2RGB_YUNV = COLOR_YUV2RGB_YUY2,
						COLOR_YUV2BGR_YUNV = COLOR_YUV2BGR_YUY2,
						COLOR_YUV2RGBA_YUY2 = 119,
						COLOR_YUV2BGRA_YUY2 = 120,
						COLOR_YUV2RGBA_YVYU = 121,
						COLOR_YUV2BGRA_YVYU = 122,
						COLOR_YUV2RGBA_YUYV = COLOR_YUV2RGBA_YUY2,
						COLOR_YUV2BGRA_YUYV = COLOR_YUV2BGRA_YUY2,
						COLOR_YUV2RGBA_YUNV = COLOR_YUV2RGBA_YUY2,
						COLOR_YUV2BGRA_YUNV = COLOR_YUV2BGRA_YUY2,
						COLOR_YUV2GRAY_UYVY = 123,
						COLOR_YUV2GRAY_YUY2 = 124,
						COLOR_YUV2GRAY_Y422 = COLOR_YUV2GRAY_UYVY,
						COLOR_YUV2GRAY_UYNV = COLOR_YUV2GRAY_UYVY,
						COLOR_YUV2GRAY_YVYU = COLOR_YUV2GRAY_YUY2,
						COLOR_YUV2GRAY_YUYV = COLOR_YUV2GRAY_YUY2,
						COLOR_YUV2GRAY_YUNV = COLOR_YUV2GRAY_YUY2,
						COLOR_RGBA2mRGBA = 125,
						COLOR_mRGBA2RGBA = 126,
						COLOR_RGB2YUV_I420 = 127,
						COLOR_BGR2YUV_I420 = 128,
						COLOR_RGB2YUV_IYUV = COLOR_RGB2YUV_I420,
						COLOR_BGR2YUV_IYUV = COLOR_BGR2YUV_I420,
						COLOR_RGBA2YUV_I420 = 129,
						COLOR_BGRA2YUV_I420 = 130,
						COLOR_RGBA2YUV_IYUV = COLOR_RGBA2YUV_I420,
						COLOR_BGRA2YUV_IYUV = COLOR_BGRA2YUV_I420,
						COLOR_RGB2YUV_YV12 = 131,
						COLOR_BGR2YUV_YV12 = 132,
						COLOR_RGBA2YUV_YV12 = 133,
						COLOR_BGRA2YUV_YV12 = 134,
						COLOR_BayerBG2BGR = 46,
						COLOR_BayerGB2BGR = 47,
						COLOR_BayerRG2BGR = 48,
						COLOR_BayerGR2BGR = 49,
						COLOR_BayerBG2RGB = COLOR_BayerRG2BGR,
						COLOR_BayerGB2RGB = COLOR_BayerGR2BGR,
						COLOR_BayerRG2RGB = COLOR_BayerBG2BGR,
						COLOR_BayerGR2RGB = COLOR_BayerGB2BGR,
						COLOR_BayerBG2GRAY = 86,
						COLOR_BayerGB2GRAY = 87,
						COLOR_BayerRG2GRAY = 88,
						COLOR_BayerGR2GRAY = 89,
						COLOR_BayerBG2BGR_VNG = 62,
						COLOR_BayerGB2BGR_VNG = 63,
						COLOR_BayerRG2BGR_VNG = 64,
						COLOR_BayerGR2BGR_VNG = 65,
						COLOR_BayerBG2RGB_VNG = COLOR_BayerRG2BGR_VNG,
						COLOR_BayerGB2RGB_VNG = COLOR_BayerGR2BGR_VNG,
						COLOR_BayerRG2RGB_VNG = COLOR_BayerBG2BGR_VNG,
						COLOR_BayerGR2RGB_VNG = COLOR_BayerGB2BGR_VNG,
						COLOR_BayerBG2BGR_EA = 135,
						COLOR_BayerGB2BGR_EA = 136,
						COLOR_BayerRG2BGR_EA = 137,
						COLOR_BayerGR2BGR_EA = 138,
						COLOR_BayerBG2RGB_EA = COLOR_BayerRG2BGR_EA,
						COLOR_BayerGB2RGB_EA = COLOR_BayerGR2BGR_EA,
						COLOR_BayerRG2RGB_EA = COLOR_BayerBG2BGR_EA,
						COLOR_BayerGR2RGB_EA = COLOR_BayerGB2BGR_EA,
						COLOR_COLORCVT_MAX = 139,
						INTERSECT_NONE = 0,
						INTERSECT_PARTIAL = 1,
						INTERSECT_FULL = 2,
						TM_SQDIFF = 0,
						TM_SQDIFF_NORMED = 1,
						TM_CCORR = 2,
						TM_CCORR_NORMED = 3,
						TM_CCOEFF = 4,
						TM_CCOEFF_NORMED = 5,
						COLORMAP_AUTUMN = 0,
						COLORMAP_BONE = 1,
						COLORMAP_JET = 2,
						COLORMAP_WINTER = 3,
						COLORMAP_RAINBOW = 4,
						COLORMAP_OCEAN = 5,
						COLORMAP_SUMMER = 6,
						COLORMAP_SPRING = 7,
						COLORMAP_COOL = 8,
						COLORMAP_HSV = 9,
						COLORMAP_PINK = 10,
						COLORMAP_HOT = 11,
						COLORMAP_PARULA = 12;
	
	
				//
				// C++:  Ptr_LineSegmentDetector createLineSegmentDetector(int _refine = LSD_REFINE_STD, double _scale = 0.8, double _sigma_scale = 0.6, double _quant = 2.0, double _ang_th = 22.5, double _log_eps = 0, double _density_th = 0.7, int _n_bins = 1024)
				//
	
				//javadoc: createLineSegmentDetector(_refine, _scale, _sigma_scale, _quant, _ang_th, _log_eps, _density_th, _n_bins)
				public static LineSegmentDetector createLineSegmentDetector (int _refine, double _scale, double _sigma_scale, double _quant, double _ang_th, double _log_eps, double _density_th, int _n_bins)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						LineSegmentDetector retVal = new LineSegmentDetector (imgproc_Imgproc_createLineSegmentDetector_10 (_refine, _scale, _sigma_scale, _quant, _ang_th, _log_eps, _density_th, _n_bins));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: createLineSegmentDetector()
				public static LineSegmentDetector createLineSegmentDetector ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						LineSegmentDetector retVal = new LineSegmentDetector (imgproc_Imgproc_createLineSegmentDetector_11 ());
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  Mat getGaussianKernel(int ksize, double sigma, int ktype = CV_64F)
				//
	
				//javadoc: getGaussianKernel(ksize, sigma, ktype)
				public static Mat getGaussianKernel (int ksize, double sigma, int ktype)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getGaussianKernel_10 (ksize, sigma, ktype));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: getGaussianKernel(ksize, sigma)
				public static Mat getGaussianKernel (int ksize, double sigma)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getGaussianKernel_11 (ksize, sigma));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void getDerivKernels(Mat& kx, Mat& ky, int dx, int dy, int ksize, bool normalize = false, int ktype = CV_32F)
				//
	
				//javadoc: getDerivKernels(kx, ky, dx, dy, ksize, normalize, ktype)
				public static void getDerivKernels (Mat kx, Mat ky, int dx, int dy, int ksize, bool normalize, int ktype)
				{
						if (kx != null)
								kx.ThrowIfDisposed ();
						if (ky != null)
								ky.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_getDerivKernels_10 (kx.nativeObj, ky.nativeObj, dx, dy, ksize, normalize, ktype);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: getDerivKernels(kx, ky, dx, dy, ksize)
				public static void getDerivKernels (Mat kx, Mat ky, int dx, int dy, int ksize)
				{
						if (kx != null)
								kx.ThrowIfDisposed ();
						if (ky != null)
								ky.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_getDerivKernels_11 (kx.nativeObj, ky.nativeObj, dx, dy, ksize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Mat getGaborKernel(Size ksize, double sigma, double theta, double lambd, double gamma, double psi = CV_PI*0.5, int ktype = CV_64F)
				//
	
				//javadoc: getGaborKernel(ksize, sigma, theta, lambd, gamma, psi, ktype)
				public static Mat getGaborKernel (Size ksize, double sigma, double theta, double lambd, double gamma, double psi, int ktype)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getGaborKernel_10 (ksize.width, ksize.height, sigma, theta, lambd, gamma, psi, ktype));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: getGaborKernel(ksize, sigma, theta, lambd, gamma)
				public static Mat getGaborKernel (Size ksize, double sigma, double theta, double lambd, double gamma)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getGaborKernel_11 (ksize.width, ksize.height, sigma, theta, lambd, gamma));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void fillConvexPoly(Mat& img, vector_Point points, Scalar color, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: fillConvexPoly(img, points, color, lineType, shift)
				public static void fillConvexPoly (Mat img, MatOfPoint points, Scalar color, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat points_mat = points;
						imgproc_Imgproc_fillConvexPoly_10 (img.nativeObj, points_mat.nativeObj, color.val [0], color.val [1], color.val [2], color.val [3], lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: fillConvexPoly(img, points, color)
				public static void fillConvexPoly (Mat img, MatOfPoint points, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat points_mat = points;
						imgproc_Imgproc_fillConvexPoly_11 (img.nativeObj, points_mat.nativeObj, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void fillPoly(Mat& img, vector_vector_Point pts, Scalar color, int lineType = LINE_8, int shift = 0, Point offset = Point())
				//
	
				//javadoc: fillPoly(img, pts, color, lineType, shift, offset)
				public static void fillPoly (Mat img, List<MatOfPoint> pts, Scalar color, int lineType, int shift, Point offset)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> pts_tmplm = new List<Mat> ((pts != null) ? pts.Count : 0);
						Mat pts_mat = Converters.vector_vector_Point_to_Mat (pts, pts_tmplm);
						imgproc_Imgproc_fillPoly_10 (img.nativeObj, pts_mat.nativeObj, color.val [0], color.val [1], color.val [2], color.val [3], lineType, shift, offset.x, offset.y);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: fillPoly(img, pts, color)
				public static void fillPoly (Mat img, List<MatOfPoint> pts, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> pts_tmplm = new List<Mat> ((pts != null) ? pts.Count : 0);
						Mat pts_mat = Converters.vector_vector_Point_to_Mat (pts, pts_tmplm);
						imgproc_Imgproc_fillPoly_11 (img.nativeObj, pts_mat.nativeObj, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void polylines(Mat& img, vector_vector_Point pts, bool isClosed, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: polylines(img, pts, isClosed, color, thickness, lineType, shift)
				public static void polylines (Mat img, List<MatOfPoint> pts, bool isClosed, Scalar color, int thickness, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> pts_tmplm = new List<Mat> ((pts != null) ? pts.Count : 0);
						Mat pts_mat = Converters.vector_vector_Point_to_Mat (pts, pts_tmplm);
						imgproc_Imgproc_polylines_10 (img.nativeObj, pts_mat.nativeObj, isClosed, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: polylines(img, pts, isClosed, color, thickness)
				public static void polylines (Mat img, List<MatOfPoint> pts, bool isClosed, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> pts_tmplm = new List<Mat> ((pts != null) ? pts.Count : 0);
						Mat pts_mat = Converters.vector_vector_Point_to_Mat (pts, pts_tmplm);
						imgproc_Imgproc_polylines_11 (img.nativeObj, pts_mat.nativeObj, isClosed, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: polylines(img, pts, isClosed, color)
				public static void polylines (Mat img, List<MatOfPoint> pts, bool isClosed, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> pts_tmplm = new List<Mat> ((pts != null) ? pts.Count : 0);
						Mat pts_mat = Converters.vector_vector_Point_to_Mat (pts, pts_tmplm);
						imgproc_Imgproc_polylines_12 (img.nativeObj, pts_mat.nativeObj, isClosed, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void drawContours(Mat& image, vector_vector_Point contours, int contourIdx, Scalar color, int thickness = 1, int lineType = LINE_8, Mat hierarchy = Mat(), int maxLevel = INT_MAX, Point offset = Point())
				//
	
				//javadoc: drawContours(image, contours, contourIdx, color, thickness, lineType, hierarchy, maxLevel, offset)
				public static void drawContours (Mat image, List<MatOfPoint> contours, int contourIdx, Scalar color, int thickness, int lineType, Mat hierarchy, int maxLevel, Point offset)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (hierarchy != null)
								hierarchy.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> contours_tmplm = new List<Mat> ((contours != null) ? contours.Count : 0);
						Mat contours_mat = Converters.vector_vector_Point_to_Mat (contours, contours_tmplm);
						imgproc_Imgproc_drawContours_10 (image.nativeObj, contours_mat.nativeObj, contourIdx, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, hierarchy.nativeObj, maxLevel, offset.x, offset.y);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: drawContours(image, contours, contourIdx, color, thickness)
				public static void drawContours (Mat image, List<MatOfPoint> contours, int contourIdx, Scalar color, int thickness)
				{
						if (image != null)
								image.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> contours_tmplm = new List<Mat> ((contours != null) ? contours.Count : 0);
						Mat contours_mat = Converters.vector_vector_Point_to_Mat (contours, contours_tmplm);
						imgproc_Imgproc_drawContours_11 (image.nativeObj, contours_mat.nativeObj, contourIdx, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: drawContours(image, contours, contourIdx, color)
				public static void drawContours (Mat image, List<MatOfPoint> contours, int contourIdx, Scalar color)
				{
						if (image != null)
								image.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						List<Mat> contours_tmplm = new List<Mat> ((contours != null) ? contours.Count : 0);
						Mat contours_mat = Converters.vector_vector_Point_to_Mat (contours, contours_tmplm);
						imgproc_Imgproc_drawContours_12 (image.nativeObj, contours_mat.nativeObj, contourIdx, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  bool clipLine(Rect imgRect, Point& pt1, Point& pt2)
				//
	
				//javadoc: clipLine(imgRect, pt1, pt2)
				public static bool clipLine (Rect imgRect, Point pt1, Point pt2)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] pt1_out = new double[2];
						double[] pt2_out = new double[2];
						bool retVal = imgproc_Imgproc_clipLine_10 (imgRect.x, imgRect.y, imgRect.width, imgRect.height, pt1.x, pt1.y, pt1_out, pt2.x, pt2.y, pt2_out);
						if (pt1 != null) {
								pt1.x = pt1_out [0];
								pt1.y = pt1_out [1];
						} 
						if (pt2 != null) {
								pt2.x = pt2_out [0];
								pt2.y = pt2_out [1];
						} 
						return retVal;
#else
return false;
#endif
				}
	
	
				//
				// C++:  void ellipse2Poly(Point center, Size axes, int angle, int arcStart, int arcEnd, int delta, vector_Point& pts)
				//
	
				//javadoc: ellipse2Poly(center, axes, angle, arcStart, arcEnd, delta, pts)
				public static void ellipse2Poly (Point center, Size axes, int angle, int arcStart, int arcEnd, int delta, MatOfPoint pts)
				{
						if (pts != null)
								pts.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat pts_mat = pts;
						imgproc_Imgproc_ellipse2Poly_10 (center.x, center.y, axes.width, axes.height, angle, arcStart, arcEnd, delta, pts_mat.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void putText(Mat& img, String text, Point org, int fontFace, double fontScale, Scalar color, int thickness = 1, int lineType = LINE_8, bool bottomLeftOrigin = false)
				//
	
				//javadoc: putText(img, text, org, fontFace, fontScale, color, thickness, lineType, bottomLeftOrigin)
				public static void putText (Mat img, string text, Point org, int fontFace, double fontScale, Scalar color, int thickness, int lineType, bool bottomLeftOrigin)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_putText_10 (img.nativeObj, text, org.x, org.y, fontFace, fontScale, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, bottomLeftOrigin);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: putText(img, text, org, fontFace, fontScale, color, thickness)
				public static void putText (Mat img, string text, Point org, int fontFace, double fontScale, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_putText_11 (img.nativeObj, text, org.x, org.y, fontFace, fontScale, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: putText(img, text, org, fontFace, fontScale, color)
				public static void putText (Mat img, string text, Point org, int fontFace, double fontScale, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_putText_12 (img.nativeObj, text, org.x, org.y, fontFace, fontScale, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Mat getStructuringElement(int shape, Size ksize, Point anchor = Point(-1,-1))
				//
	
				//javadoc: getStructuringElement(shape, ksize, anchor)
				public static Mat getStructuringElement (int shape, Size ksize, Point anchor)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getStructuringElement_10 (shape, ksize.width, ksize.height, anchor.x, anchor.y));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: getStructuringElement(shape, ksize)
				public static Mat getStructuringElement (int shape, Size ksize)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getStructuringElement_11 (shape, ksize.width, ksize.height));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void medianBlur(Mat src, Mat& dst, int ksize)
				//
	
				//javadoc: medianBlur(src, dst, ksize)
				public static void medianBlur (Mat src, Mat dst, int ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_medianBlur_10 (src.nativeObj, dst.nativeObj, ksize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void GaussianBlur(Mat src, Mat& dst, Size ksize, double sigmaX, double sigmaY = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: GaussianBlur(src, dst, ksize, sigmaX, sigmaY, borderType)
				public static void GaussianBlur (Mat src, Mat dst, Size ksize, double sigmaX, double sigmaY, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_GaussianBlur_10 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height, sigmaX, sigmaY, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: GaussianBlur(src, dst, ksize, sigmaX, sigmaY)
				public static void GaussianBlur (Mat src, Mat dst, Size ksize, double sigmaX, double sigmaY)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_GaussianBlur_11 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height, sigmaX, sigmaY);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: GaussianBlur(src, dst, ksize, sigmaX)
				public static void GaussianBlur (Mat src, Mat dst, Size ksize, double sigmaX)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_GaussianBlur_12 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height, sigmaX);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void bilateralFilter(Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: bilateralFilter(src, dst, d, sigmaColor, sigmaSpace, borderType)
				public static void bilateralFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_bilateralFilter_10 (src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: bilateralFilter(src, dst, d, sigmaColor, sigmaSpace)
				public static void bilateralFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_bilateralFilter_11 (src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void boxFilter(Mat src, Mat& dst, int ddepth, Size ksize, Point anchor = Point(-1,-1), bool normalize = true, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: boxFilter(src, dst, ddepth, ksize, anchor, normalize, borderType)
				public static void boxFilter (Mat src, Mat dst, int ddepth, Size ksize, Point anchor, bool normalize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_boxFilter_10 (src.nativeObj, dst.nativeObj, ddepth, ksize.width, ksize.height, anchor.x, anchor.y, normalize, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: boxFilter(src, dst, ddepth, ksize, anchor, normalize)
				public static void boxFilter (Mat src, Mat dst, int ddepth, Size ksize, Point anchor, bool normalize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_boxFilter_11 (src.nativeObj, dst.nativeObj, ddepth, ksize.width, ksize.height, anchor.x, anchor.y, normalize);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: boxFilter(src, dst, ddepth, ksize)
				public static void boxFilter (Mat src, Mat dst, int ddepth, Size ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_boxFilter_12 (src.nativeObj, dst.nativeObj, ddepth, ksize.width, ksize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void sqrBoxFilter(Mat _src, Mat& _dst, int ddepth, Size ksize, Point anchor = Point(-1, -1), bool normalize = true, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: sqrBoxFilter(_src, _dst, ddepth, ksize, anchor, normalize, borderType)
				public static void sqrBoxFilter (Mat _src, Mat _dst, int ddepth, Size ksize, Point anchor, bool normalize, int borderType)
				{
						if (_src != null)
								_src.ThrowIfDisposed ();
						if (_dst != null)
								_dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sqrBoxFilter_10 (_src.nativeObj, _dst.nativeObj, ddepth, ksize.width, ksize.height, anchor.x, anchor.y, normalize, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: sqrBoxFilter(_src, _dst, ddepth, ksize, anchor, normalize)
				public static void sqrBoxFilter (Mat _src, Mat _dst, int ddepth, Size ksize, Point anchor, bool normalize)
				{
						if (_src != null)
								_src.ThrowIfDisposed ();
						if (_dst != null)
								_dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sqrBoxFilter_11 (_src.nativeObj, _dst.nativeObj, ddepth, ksize.width, ksize.height, anchor.x, anchor.y, normalize);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: sqrBoxFilter(_src, _dst, ddepth, ksize)
				public static void sqrBoxFilter (Mat _src, Mat _dst, int ddepth, Size ksize)
				{
						if (_src != null)
								_src.ThrowIfDisposed ();
						if (_dst != null)
								_dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sqrBoxFilter_12 (_src.nativeObj, _dst.nativeObj, ddepth, ksize.width, ksize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void blur(Mat src, Mat& dst, Size ksize, Point anchor = Point(-1,-1), int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: blur(src, dst, ksize, anchor, borderType)
				public static void blur (Mat src, Mat dst, Size ksize, Point anchor, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_blur_10 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height, anchor.x, anchor.y, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: blur(src, dst, ksize, anchor)
				public static void blur (Mat src, Mat dst, Size ksize, Point anchor)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_blur_11 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height, anchor.x, anchor.y);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: blur(src, dst, ksize)
				public static void blur (Mat src, Mat dst, Size ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_blur_12 (src.nativeObj, dst.nativeObj, ksize.width, ksize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void filter2D(Mat src, Mat& dst, int ddepth, Mat kernel, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: filter2D(src, dst, ddepth, kernel, anchor, delta, borderType)
				public static void filter2D (Mat src, Mat dst, int ddepth, Mat kernel, Point anchor, double delta, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_filter2D_10 (src.nativeObj, dst.nativeObj, ddepth, kernel.nativeObj, anchor.x, anchor.y, delta, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: filter2D(src, dst, ddepth, kernel, anchor, delta)
				public static void filter2D (Mat src, Mat dst, int ddepth, Mat kernel, Point anchor, double delta)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_filter2D_11 (src.nativeObj, dst.nativeObj, ddepth, kernel.nativeObj, anchor.x, anchor.y, delta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: filter2D(src, dst, ddepth, kernel)
				public static void filter2D (Mat src, Mat dst, int ddepth, Mat kernel)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_filter2D_12 (src.nativeObj, dst.nativeObj, ddepth, kernel.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void sepFilter2D(Mat src, Mat& dst, int ddepth, Mat kernelX, Mat kernelY, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: sepFilter2D(src, dst, ddepth, kernelX, kernelY, anchor, delta, borderType)
				public static void sepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY, Point anchor, double delta, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernelX != null)
								kernelX.ThrowIfDisposed ();
						if (kernelY != null)
								kernelY.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sepFilter2D_10 (src.nativeObj, dst.nativeObj, ddepth, kernelX.nativeObj, kernelY.nativeObj, anchor.x, anchor.y, delta, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: sepFilter2D(src, dst, ddepth, kernelX, kernelY, anchor, delta)
				public static void sepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY, Point anchor, double delta)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernelX != null)
								kernelX.ThrowIfDisposed ();
						if (kernelY != null)
								kernelY.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sepFilter2D_11 (src.nativeObj, dst.nativeObj, ddepth, kernelX.nativeObj, kernelY.nativeObj, anchor.x, anchor.y, delta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: sepFilter2D(src, dst, ddepth, kernelX, kernelY)
				public static void sepFilter2D (Mat src, Mat dst, int ddepth, Mat kernelX, Mat kernelY)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernelX != null)
								kernelX.ThrowIfDisposed ();
						if (kernelY != null)
								kernelY.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_sepFilter2D_12 (src.nativeObj, dst.nativeObj, ddepth, kernelX.nativeObj, kernelY.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void Sobel(Mat src, Mat& dst, int ddepth, int dx, int dy, int ksize = 3, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: Sobel(src, dst, ddepth, dx, dy, ksize, scale, delta, borderType)
				public static void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize, double scale, double delta, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Sobel_10 (src.nativeObj, dst.nativeObj, ddepth, dx, dy, ksize, scale, delta, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Sobel(src, dst, ddepth, dx, dy, ksize, scale, delta)
				public static void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy, int ksize, double scale, double delta)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Sobel_11 (src.nativeObj, dst.nativeObj, ddepth, dx, dy, ksize, scale, delta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Sobel(src, dst, ddepth, dx, dy)
				public static void Sobel (Mat src, Mat dst, int ddepth, int dx, int dy)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Sobel_12 (src.nativeObj, dst.nativeObj, ddepth, dx, dy);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void Scharr(Mat src, Mat& dst, int ddepth, int dx, int dy, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: Scharr(src, dst, ddepth, dx, dy, scale, delta, borderType)
				public static void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy, double scale, double delta, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Scharr_10 (src.nativeObj, dst.nativeObj, ddepth, dx, dy, scale, delta, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Scharr(src, dst, ddepth, dx, dy, scale, delta)
				public static void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy, double scale, double delta)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Scharr_11 (src.nativeObj, dst.nativeObj, ddepth, dx, dy, scale, delta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Scharr(src, dst, ddepth, dx, dy)
				public static void Scharr (Mat src, Mat dst, int ddepth, int dx, int dy)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Scharr_12 (src.nativeObj, dst.nativeObj, ddepth, dx, dy);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void Laplacian(Mat src, Mat& dst, int ddepth, int ksize = 1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: Laplacian(src, dst, ddepth, ksize, scale, delta, borderType)
				public static void Laplacian (Mat src, Mat dst, int ddepth, int ksize, double scale, double delta, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Laplacian_10 (src.nativeObj, dst.nativeObj, ddepth, ksize, scale, delta, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Laplacian(src, dst, ddepth, ksize, scale, delta)
				public static void Laplacian (Mat src, Mat dst, int ddepth, int ksize, double scale, double delta)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Laplacian_11 (src.nativeObj, dst.nativeObj, ddepth, ksize, scale, delta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Laplacian(src, dst, ddepth)
				public static void Laplacian (Mat src, Mat dst, int ddepth)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Laplacian_12 (src.nativeObj, dst.nativeObj, ddepth);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void Canny(Mat image, Mat& edges, double threshold1, double threshold2, int apertureSize = 3, bool L2gradient = false)
				//
	
				//javadoc: Canny(image, edges, threshold1, threshold2, apertureSize, L2gradient)
				public static void Canny (Mat image, Mat edges, double threshold1, double threshold2, int apertureSize, bool L2gradient)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (edges != null)
								edges.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Canny_10 (image.nativeObj, edges.nativeObj, threshold1, threshold2, apertureSize, L2gradient);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: Canny(image, edges, threshold1, threshold2)
				public static void Canny (Mat image, Mat edges, double threshold1, double threshold2)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (edges != null)
								edges.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_Canny_11 (image.nativeObj, edges.nativeObj, threshold1, threshold2);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void cornerMinEigenVal(Mat src, Mat& dst, int blockSize, int ksize = 3, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: cornerMinEigenVal(src, dst, blockSize, ksize, borderType)
				public static void cornerMinEigenVal (Mat src, Mat dst, int blockSize, int ksize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerMinEigenVal_10 (src.nativeObj, dst.nativeObj, blockSize, ksize, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: cornerMinEigenVal(src, dst, blockSize, ksize)
				public static void cornerMinEigenVal (Mat src, Mat dst, int blockSize, int ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerMinEigenVal_11 (src.nativeObj, dst.nativeObj, blockSize, ksize);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: cornerMinEigenVal(src, dst, blockSize)
				public static void cornerMinEigenVal (Mat src, Mat dst, int blockSize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerMinEigenVal_12 (src.nativeObj, dst.nativeObj, blockSize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void cornerHarris(Mat src, Mat& dst, int blockSize, int ksize, double k, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: cornerHarris(src, dst, blockSize, ksize, k, borderType)
				public static void cornerHarris (Mat src, Mat dst, int blockSize, int ksize, double k, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerHarris_10 (src.nativeObj, dst.nativeObj, blockSize, ksize, k, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: cornerHarris(src, dst, blockSize, ksize, k)
				public static void cornerHarris (Mat src, Mat dst, int blockSize, int ksize, double k)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerHarris_11 (src.nativeObj, dst.nativeObj, blockSize, ksize, k);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void cornerEigenValsAndVecs(Mat src, Mat& dst, int blockSize, int ksize, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: cornerEigenValsAndVecs(src, dst, blockSize, ksize, borderType)
				public static void cornerEigenValsAndVecs (Mat src, Mat dst, int blockSize, int ksize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerEigenValsAndVecs_10 (src.nativeObj, dst.nativeObj, blockSize, ksize, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: cornerEigenValsAndVecs(src, dst, blockSize, ksize)
				public static void cornerEigenValsAndVecs (Mat src, Mat dst, int blockSize, int ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cornerEigenValsAndVecs_11 (src.nativeObj, dst.nativeObj, blockSize, ksize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void preCornerDetect(Mat src, Mat& dst, int ksize, int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: preCornerDetect(src, dst, ksize, borderType)
				public static void preCornerDetect (Mat src, Mat dst, int ksize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_preCornerDetect_10 (src.nativeObj, dst.nativeObj, ksize, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: preCornerDetect(src, dst, ksize)
				public static void preCornerDetect (Mat src, Mat dst, int ksize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_preCornerDetect_11 (src.nativeObj, dst.nativeObj, ksize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void cornerSubPix(Mat image, vector_Point2f& corners, Size winSize, Size zeroZone, TermCriteria criteria)
				//
	
				//javadoc: cornerSubPix(image, corners, winSize, zeroZone, criteria)
				public static void cornerSubPix (Mat image, MatOfPoint2f corners, Size winSize, Size zeroZone, TermCriteria criteria)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (corners != null)
								corners.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat corners_mat = corners;
						imgproc_Imgproc_cornerSubPix_10 (image.nativeObj, corners_mat.nativeObj, winSize.width, winSize.height, zeroZone.width, zeroZone.height, criteria.type, criteria.maxCount, criteria.epsilon);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void goodFeaturesToTrack(Mat image, vector_Point& corners, int maxCorners, double qualityLevel, double minDistance, Mat mask = Mat(), int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
				//
	
				//javadoc: goodFeaturesToTrack(image, corners, maxCorners, qualityLevel, minDistance, mask, blockSize, useHarrisDetector, k)
				public static void goodFeaturesToTrack (Mat image, MatOfPoint corners, int maxCorners, double qualityLevel, double minDistance, Mat mask, int blockSize, bool useHarrisDetector, double k)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (corners != null)
								corners.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat corners_mat = corners;
						imgproc_Imgproc_goodFeaturesToTrack_10 (image.nativeObj, corners_mat.nativeObj, maxCorners, qualityLevel, minDistance, mask.nativeObj, blockSize, useHarrisDetector, k);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: goodFeaturesToTrack(image, corners, maxCorners, qualityLevel, minDistance)
				public static void goodFeaturesToTrack (Mat image, MatOfPoint corners, int maxCorners, double qualityLevel, double minDistance)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (corners != null)
								corners.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat corners_mat = corners;
						imgproc_Imgproc_goodFeaturesToTrack_11 (image.nativeObj, corners_mat.nativeObj, maxCorners, qualityLevel, minDistance);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void HoughLines(Mat image, Mat& lines, double rho, double theta, int threshold, double srn = 0, double stn = 0, double min_theta = 0, double max_theta = CV_PI)
				//
	
				//javadoc: HoughLines(image, lines, rho, theta, threshold, srn, stn, min_theta, max_theta)
				public static void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (lines != null)
								lines.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughLines_10 (image.nativeObj, lines.nativeObj, rho, theta, threshold, srn, stn, min_theta, max_theta);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: HoughLines(image, lines, rho, theta, threshold)
				public static void HoughLines (Mat image, Mat lines, double rho, double theta, int threshold)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (lines != null)
								lines.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughLines_11 (image.nativeObj, lines.nativeObj, rho, theta, threshold);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void HoughLinesP(Mat image, Mat& lines, double rho, double theta, int threshold, double minLineLength = 0, double maxLineGap = 0)
				//
	
				//javadoc: HoughLinesP(image, lines, rho, theta, threshold, minLineLength, maxLineGap)
				public static void HoughLinesP (Mat image, Mat lines, double rho, double theta, int threshold, double minLineLength, double maxLineGap)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (lines != null)
								lines.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughLinesP_10 (image.nativeObj, lines.nativeObj, rho, theta, threshold, minLineLength, maxLineGap);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: HoughLinesP(image, lines, rho, theta, threshold)
				public static void HoughLinesP (Mat image, Mat lines, double rho, double theta, int threshold)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (lines != null)
								lines.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughLinesP_11 (image.nativeObj, lines.nativeObj, rho, theta, threshold);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void HoughCircles(Mat image, Mat& circles, int method, double dp, double minDist, double param1 = 100, double param2 = 100, int minRadius = 0, int maxRadius = 0)
				//
	
				//javadoc: HoughCircles(image, circles, method, dp, minDist, param1, param2, minRadius, maxRadius)
				public static void HoughCircles (Mat image, Mat circles, int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (circles != null)
								circles.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughCircles_10 (image.nativeObj, circles.nativeObj, method, dp, minDist, param1, param2, minRadius, maxRadius);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: HoughCircles(image, circles, method, dp, minDist)
				public static void HoughCircles (Mat image, Mat circles, int method, double dp, double minDist)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (circles != null)
								circles.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_HoughCircles_11 (image.nativeObj, circles.nativeObj, method, dp, minDist);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void erode(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				//
	
				//javadoc: erode(src, dst, kernel, anchor, iterations, borderType, borderValue)
				public static void erode (Mat src, Mat dst, Mat kernel, Point anchor, int iterations, int borderType, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_erode_10 (src.nativeObj, dst.nativeObj, kernel.nativeObj, anchor.x, anchor.y, iterations, borderType, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: erode(src, dst, kernel, anchor, iterations)
				public static void erode (Mat src, Mat dst, Mat kernel, Point anchor, int iterations)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_erode_11 (src.nativeObj, dst.nativeObj, kernel.nativeObj, anchor.x, anchor.y, iterations);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: erode(src, dst, kernel)
				public static void erode (Mat src, Mat dst, Mat kernel)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_erode_12 (src.nativeObj, dst.nativeObj, kernel.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void dilate(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				//
	
				//javadoc: dilate(src, dst, kernel, anchor, iterations, borderType, borderValue)
				public static void dilate (Mat src, Mat dst, Mat kernel, Point anchor, int iterations, int borderType, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_dilate_10 (src.nativeObj, dst.nativeObj, kernel.nativeObj, anchor.x, anchor.y, iterations, borderType, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: dilate(src, dst, kernel, anchor, iterations)
				public static void dilate (Mat src, Mat dst, Mat kernel, Point anchor, int iterations)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_dilate_11 (src.nativeObj, dst.nativeObj, kernel.nativeObj, anchor.x, anchor.y, iterations);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: dilate(src, dst, kernel)
				public static void dilate (Mat src, Mat dst, Mat kernel)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_dilate_12 (src.nativeObj, dst.nativeObj, kernel.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void morphologyEx(Mat src, Mat& dst, int op, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				//
	
				//javadoc: morphologyEx(src, dst, op, kernel, anchor, iterations, borderType, borderValue)
				public static void morphologyEx (Mat src, Mat dst, int op, Mat kernel, Point anchor, int iterations, int borderType, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_morphologyEx_10 (src.nativeObj, dst.nativeObj, op, kernel.nativeObj, anchor.x, anchor.y, iterations, borderType, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: morphologyEx(src, dst, op, kernel, anchor, iterations)
				public static void morphologyEx (Mat src, Mat dst, int op, Mat kernel, Point anchor, int iterations)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_morphologyEx_11 (src.nativeObj, dst.nativeObj, op, kernel.nativeObj, anchor.x, anchor.y, iterations);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: morphologyEx(src, dst, op, kernel)
				public static void morphologyEx (Mat src, Mat dst, int op, Mat kernel)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (kernel != null)
								kernel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_morphologyEx_12 (src.nativeObj, dst.nativeObj, op, kernel.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void resize(Mat src, Mat& dst, Size dsize, double fx = 0, double fy = 0, int interpolation = INTER_LINEAR)
				//
	
				//javadoc: resize(src, dst, dsize, fx, fy, interpolation)
				public static void resize (Mat src, Mat dst, Size dsize, double fx, double fy, int interpolation)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_resize_10 (src.nativeObj, dst.nativeObj, dsize.width, dsize.height, fx, fy, interpolation);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: resize(src, dst, dsize)
				public static void resize (Mat src, Mat dst, Size dsize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_resize_11 (src.nativeObj, dst.nativeObj, dsize.width, dsize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void warpAffine(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				//
	
				//javadoc: warpAffine(src, dst, M, dsize, flags, borderMode, borderValue)
				public static void warpAffine (Mat src, Mat dst, Mat M, Size dsize, int flags, int borderMode, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpAffine_10 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height, flags, borderMode, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: warpAffine(src, dst, M, dsize, flags)
				public static void warpAffine (Mat src, Mat dst, Mat M, Size dsize, int flags)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpAffine_11 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height, flags);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: warpAffine(src, dst, M, dsize)
				public static void warpAffine (Mat src, Mat dst, Mat M, Size dsize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpAffine_12 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void warpPerspective(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				//
	
				//javadoc: warpPerspective(src, dst, M, dsize, flags, borderMode, borderValue)
				public static void warpPerspective (Mat src, Mat dst, Mat M, Size dsize, int flags, int borderMode, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpPerspective_10 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height, flags, borderMode, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: warpPerspective(src, dst, M, dsize, flags)
				public static void warpPerspective (Mat src, Mat dst, Mat M, Size dsize, int flags)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpPerspective_11 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height, flags);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: warpPerspective(src, dst, M, dsize)
				public static void warpPerspective (Mat src, Mat dst, Mat M, Size dsize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (M != null)
								M.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_warpPerspective_12 (src.nativeObj, dst.nativeObj, M.nativeObj, dsize.width, dsize.height);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void remap(Mat src, Mat& dst, Mat map1, Mat map2, int interpolation, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				//
	
				//javadoc: remap(src, dst, map1, map2, interpolation, borderMode, borderValue)
				public static void remap (Mat src, Mat dst, Mat map1, Mat map2, int interpolation, int borderMode, Scalar borderValue)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_remap_10 (src.nativeObj, dst.nativeObj, map1.nativeObj, map2.nativeObj, interpolation, borderMode, borderValue.val [0], borderValue.val [1], borderValue.val [2], borderValue.val [3]);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: remap(src, dst, map1, map2, interpolation)
				public static void remap (Mat src, Mat dst, Mat map1, Mat map2, int interpolation)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_remap_11 (src.nativeObj, dst.nativeObj, map1.nativeObj, map2.nativeObj, interpolation);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, Mat& tilted, int sdepth = -1, int sqdepth = -1)
				//
	
				//javadoc: integral(src, sum, sqsum, tilted, sdepth, sqdepth)
				public static void integral3 (Mat src, Mat sum, Mat sqsum, Mat tilted, int sdepth, int sqdepth)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();
						if (sqsum != null)
								sqsum.ThrowIfDisposed ();
						if (tilted != null)
								tilted.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral3_10 (src.nativeObj, sum.nativeObj, sqsum.nativeObj, tilted.nativeObj, sdepth, sqdepth);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: integral(src, sum, sqsum, tilted)
				public static void integral3 (Mat src, Mat sum, Mat sqsum, Mat tilted)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();
						if (sqsum != null)
								sqsum.ThrowIfDisposed ();
						if (tilted != null)
								tilted.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral3_11 (src.nativeObj, sum.nativeObj, sqsum.nativeObj, tilted.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void accumulate(Mat src, Mat& dst, Mat mask = Mat())
				//
	
				//javadoc: accumulate(src, dst, mask)
				public static void accumulate (Mat src, Mat dst, Mat mask)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulate_10 (src.nativeObj, dst.nativeObj, mask.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: accumulate(src, dst)
				public static void accumulate (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulate_11 (src.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void accumulateSquare(Mat src, Mat& dst, Mat mask = Mat())
				//
	
				//javadoc: accumulateSquare(src, dst, mask)
				public static void accumulateSquare (Mat src, Mat dst, Mat mask)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateSquare_10 (src.nativeObj, dst.nativeObj, mask.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: accumulateSquare(src, dst)
				public static void accumulateSquare (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateSquare_11 (src.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void accumulateProduct(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
				//
	
				//javadoc: accumulateProduct(src1, src2, dst, mask)
				public static void accumulateProduct (Mat src1, Mat src2, Mat dst, Mat mask)
				{
						if (src1 != null)
								src1.ThrowIfDisposed ();
						if (src2 != null)
								src2.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateProduct_10 (src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: accumulateProduct(src1, src2, dst)
				public static void accumulateProduct (Mat src1, Mat src2, Mat dst)
				{
						if (src1 != null)
								src1.ThrowIfDisposed ();
						if (src2 != null)
								src2.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateProduct_11 (src1.nativeObj, src2.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void accumulateWeighted(Mat src, Mat& dst, double alpha, Mat mask = Mat())
				//
	
				//javadoc: accumulateWeighted(src, dst, alpha, mask)
				public static void accumulateWeighted (Mat src, Mat dst, double alpha, Mat mask)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateWeighted_10 (src.nativeObj, dst.nativeObj, alpha, mask.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: accumulateWeighted(src, dst, alpha)
				public static void accumulateWeighted (Mat src, Mat dst, double alpha)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_accumulateWeighted_11 (src.nativeObj, dst.nativeObj, alpha);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Point2d phaseCorrelate(Mat src1, Mat src2, Mat window = Mat(), double* response = 0)
				//
	
				//javadoc: phaseCorrelate(src1, src2, window, response)
				public static Point phaseCorrelate (Mat src1, Mat src2, Mat window, double[] response)
				{
						if (src1 != null)
								src1.ThrowIfDisposed ();
						if (src2 != null)
								src2.ThrowIfDisposed ();
						if (window != null)
								window.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] response_out = new double[1];
						double[] tmpArray = new double[2];
			
						imgproc_Imgproc_phaseCorrelate_10 (src1.nativeObj, src2.nativeObj, window.nativeObj, response_out, tmpArray);
			
						Point retVal = new Point (tmpArray);
			
						if (response != null)
								response [0] = (double)response_out [0];
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: phaseCorrelate(src1, src2)
				public static Point phaseCorrelate (Mat src1, Mat src2)
				{
						if (src1 != null)
								src1.ThrowIfDisposed ();
						if (src2 != null)
								src2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double[] tmpArray = new double[2];
			
						imgproc_Imgproc_phaseCorrelate_11 (src1.nativeObj, src2.nativeObj, tmpArray);
			
						Point retVal = new Point (tmpArray);
			
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void createHanningWindow(Mat& dst, Size winSize, int type)
				//
	
				//javadoc: createHanningWindow(dst, winSize, type)
				public static void createHanningWindow (Mat dst, Size winSize, int type)
				{
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_createHanningWindow_10 (dst.nativeObj, winSize.width, winSize.height, type);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  double threshold(Mat src, Mat& dst, double thresh, double maxval, int type)
				//
	
				//javadoc: threshold(src, dst, thresh, maxval, type)
				public static double threshold (Mat src, Mat dst, double thresh, double maxval, int type)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_threshold_10 (src.nativeObj, dst.nativeObj, thresh, maxval, type);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  void adaptiveThreshold(Mat src, Mat& dst, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C)
				//
	
				//javadoc: adaptiveThreshold(src, dst, maxValue, adaptiveMethod, thresholdType, blockSize, C)
				public static void adaptiveThreshold (Mat src, Mat dst, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_adaptiveThreshold_10 (src.nativeObj, dst.nativeObj, maxValue, adaptiveMethod, thresholdType, blockSize, C);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void pyrDown(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: pyrDown(src, dst, dstsize, borderType)
				public static void pyrDown (Mat src, Mat dst, Size dstsize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrDown_10 (src.nativeObj, dst.nativeObj, dstsize.width, dstsize.height, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: pyrDown(src, dst, dstsize)
				public static void pyrDown (Mat src, Mat dst, Size dstsize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrDown_11 (src.nativeObj, dst.nativeObj, dstsize.width, dstsize.height);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: pyrDown(src, dst)
				public static void pyrDown (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrDown_12 (src.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void pyrUp(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
				//
	
				//javadoc: pyrUp(src, dst, dstsize, borderType)
				public static void pyrUp (Mat src, Mat dst, Size dstsize, int borderType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrUp_10 (src.nativeObj, dst.nativeObj, dstsize.width, dstsize.height, borderType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: pyrUp(src, dst, dstsize)
				public static void pyrUp (Mat src, Mat dst, Size dstsize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrUp_11 (src.nativeObj, dst.nativeObj, dstsize.width, dstsize.height);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: pyrUp(src, dst)
				public static void pyrUp (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrUp_12 (src.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
				//
	
				//javadoc: undistort(src, dst, cameraMatrix, distCoeffs, newCameraMatrix)
				public static void undistort (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();
						if (newCameraMatrix != null)
								newCameraMatrix.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_undistort_10 (src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, newCameraMatrix.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: undistort(src, dst, cameraMatrix, distCoeffs)
				public static void undistort (Mat src, Mat dst, Mat cameraMatrix, Mat distCoeffs)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_undistort_11 (src.nativeObj, dst.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
				//
	
				//javadoc: initUndistortRectifyMap(cameraMatrix, distCoeffs, R, newCameraMatrix, size, m1type, map1, map2)
				public static void initUndistortRectifyMap (Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat map1, Mat map2)
				{
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();
						if (R != null)
								R.ThrowIfDisposed ();
						if (newCameraMatrix != null)
								newCameraMatrix.ThrowIfDisposed ();
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_initUndistortRectifyMap_10 (cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, newCameraMatrix.nativeObj, size.width, size.height, m1type, map1.nativeObj, map2.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  float initWideAngleProjMap(Mat cameraMatrix, Mat distCoeffs, Size imageSize, int destImageWidth, int m1type, Mat& map1, Mat& map2, int projType = PROJ_SPHERICAL_EQRECT, double alpha = 0)
				//
	
				//javadoc: initWideAngleProjMap(cameraMatrix, distCoeffs, imageSize, destImageWidth, m1type, map1, map2, projType, alpha)
				public static float initWideAngleProjMap (Mat cameraMatrix, Mat distCoeffs, Size imageSize, int destImageWidth, int m1type, Mat map1, Mat map2, int projType, double alpha)
				{
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						float retVal = imgproc_Imgproc_initWideAngleProjMap_10 (cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, destImageWidth, m1type, map1.nativeObj, map2.nativeObj, projType, alpha);
		
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: initWideAngleProjMap(cameraMatrix, distCoeffs, imageSize, destImageWidth, m1type, map1, map2)
				public static float initWideAngleProjMap (Mat cameraMatrix, Mat distCoeffs, Size imageSize, int destImageWidth, int m1type, Mat map1, Mat map2)
				{
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						float retVal = imgproc_Imgproc_initWideAngleProjMap_11 (cameraMatrix.nativeObj, distCoeffs.nativeObj, imageSize.width, imageSize.height, destImageWidth, m1type, map1.nativeObj, map2.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
				//
	
				//javadoc: getDefaultNewCameraMatrix(cameraMatrix, imgsize, centerPrincipalPoint)
				public static Mat getDefaultNewCameraMatrix (Mat cameraMatrix, Size imgsize, bool centerPrincipalPoint)
				{
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getDefaultNewCameraMatrix_10 (cameraMatrix.nativeObj, imgsize.width, imgsize.height, centerPrincipalPoint));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: getDefaultNewCameraMatrix(cameraMatrix)
				public static Mat getDefaultNewCameraMatrix (Mat cameraMatrix)
				{
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getDefaultNewCameraMatrix_11 (cameraMatrix.nativeObj));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
				//
	
				//javadoc: undistortPoints(src, dst, cameraMatrix, distCoeffs, R, P)
				public static void undistortPoints (MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs, Mat R, Mat P)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();
						if (R != null)
								R.ThrowIfDisposed ();
						if (P != null)
								P.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat src_mat = src;
						Mat dst_mat = dst;
						imgproc_Imgproc_undistortPoints_10 (src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj, R.nativeObj, P.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: undistortPoints(src, dst, cameraMatrix, distCoeffs)
				public static void undistortPoints (MatOfPoint2f src, MatOfPoint2f dst, Mat cameraMatrix, Mat distCoeffs)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (cameraMatrix != null)
								cameraMatrix.ThrowIfDisposed ();
						if (distCoeffs != null)
								distCoeffs.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat src_mat = src;
						Mat dst_mat = dst;
						imgproc_Imgproc_undistortPoints_11 (src_mat.nativeObj, dst_mat.nativeObj, cameraMatrix.nativeObj, distCoeffs.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void calcHist(vector_Mat images, vector_int channels, Mat mask, Mat& hist, vector_int histSize, vector_float ranges, bool accumulate = false)
				//
	
				//javadoc: calcHist(images, channels, mask, hist, histSize, ranges, accumulate)
				public static void calcHist (List<Mat> images, MatOfInt channels, Mat mask, Mat hist, MatOfInt histSize, MatOfFloat ranges, bool accumulate)
				{
						if (channels != null)
								channels.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						if (hist != null)
								hist.ThrowIfDisposed ();
						if (histSize != null)
								histSize.ThrowIfDisposed ();
						if (ranges != null)
								ranges.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						Mat channels_mat = channels;
						Mat histSize_mat = histSize;
						Mat ranges_mat = ranges;
						imgproc_Imgproc_calcHist_10 (images_mat.nativeObj, channels_mat.nativeObj, mask.nativeObj, hist.nativeObj, histSize_mat.nativeObj, ranges_mat.nativeObj, accumulate);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: calcHist(images, channels, mask, hist, histSize, ranges)
				public static void calcHist (List<Mat> images, MatOfInt channels, Mat mask, Mat hist, MatOfInt histSize, MatOfFloat ranges)
				{
						if (channels != null)
								channels.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						if (hist != null)
								hist.ThrowIfDisposed ();
						if (histSize != null)
								histSize.ThrowIfDisposed ();
						if (ranges != null)
								ranges.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						Mat channels_mat = channels;
						Mat histSize_mat = histSize;
						Mat ranges_mat = ranges;
						imgproc_Imgproc_calcHist_11 (images_mat.nativeObj, channels_mat.nativeObj, mask.nativeObj, hist.nativeObj, histSize_mat.nativeObj, ranges_mat.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void convertMaps(Mat map1, Mat map2, Mat& dstmap1, Mat& dstmap2, int dstmap1type, bool nninterpolation = false)
				//
	
				//javadoc: convertMaps(map1, map2, dstmap1, dstmap2, dstmap1type, nninterpolation)
				public static void convertMaps (Mat map1, Mat map2, Mat dstmap1, Mat dstmap2, int dstmap1type, bool nninterpolation)
				{
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();
						if (dstmap1 != null)
								dstmap1.ThrowIfDisposed ();
						if (dstmap2 != null)
								dstmap2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_convertMaps_10 (map1.nativeObj, map2.nativeObj, dstmap1.nativeObj, dstmap2.nativeObj, dstmap1type, nninterpolation);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: convertMaps(map1, map2, dstmap1, dstmap2, dstmap1type)
				public static void convertMaps (Mat map1, Mat map2, Mat dstmap1, Mat dstmap2, int dstmap1type)
				{
						if (map1 != null)
								map1.ThrowIfDisposed ();
						if (map2 != null)
								map2.ThrowIfDisposed ();
						if (dstmap1 != null)
								dstmap1.ThrowIfDisposed ();
						if (dstmap2 != null)
								dstmap2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_convertMaps_11 (map1.nativeObj, map2.nativeObj, dstmap1.nativeObj, dstmap2.nativeObj, dstmap1type);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Mat getRotationMatrix2D(Point2f center, double angle, double scale)
				//
	
				//javadoc: getRotationMatrix2D(center, angle, scale)
				public static Mat getRotationMatrix2D (Point center, double angle, double scale)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getRotationMatrix2D_10 (center.x, center.y, angle, scale));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void invertAffineTransform(Mat M, Mat& iM)
				//
	
				//javadoc: invertAffineTransform(M, iM)
				public static void invertAffineTransform (Mat M, Mat iM)
				{
						if (M != null)
								M.ThrowIfDisposed ();
						if (iM != null)
								iM.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_invertAffineTransform_10 (M.nativeObj, iM.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Mat getPerspectiveTransform(Mat src, Mat dst)
				//
	
				//javadoc: getPerspectiveTransform(src, dst)
				public static Mat getPerspectiveTransform (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						Mat retVal = new Mat (imgproc_Imgproc_getPerspectiveTransform_10 (src.nativeObj, dst.nativeObj));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  Mat getAffineTransform(vector_Point2f src, vector_Point2f dst)
				//
	
				//javadoc: getAffineTransform(src, dst)
				public static Mat getAffineTransform (MatOfPoint2f src, MatOfPoint2f dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat src_mat = src;
						Mat dst_mat = dst;
						Mat retVal = new Mat (imgproc_Imgproc_getAffineTransform_10 (src_mat.nativeObj, dst_mat.nativeObj));
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void getRectSubPix(Mat image, Size patchSize, Point2f center, Mat& patch, int patchType = -1)
				//
	
				//javadoc: getRectSubPix(image, patchSize, center, patch, patchType)
				public static void getRectSubPix (Mat image, Size patchSize, Point center, Mat patch, int patchType)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (patch != null)
								patch.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_getRectSubPix_10 (image.nativeObj, patchSize.width, patchSize.height, center.x, center.y, patch.nativeObj, patchType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: getRectSubPix(image, patchSize, center, patch)
				public static void getRectSubPix (Mat image, Size patchSize, Point center, Mat patch)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (patch != null)
								patch.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_getRectSubPix_11 (image.nativeObj, patchSize.width, patchSize.height, center.x, center.y, patch.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void logPolar(Mat src, Mat& dst, Point2f center, double M, int flags)
				//
	
				//javadoc: logPolar(src, dst, center, M, flags)
				public static void logPolar (Mat src, Mat dst, Point center, double M, int flags)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_logPolar_10 (src.nativeObj, dst.nativeObj, center.x, center.y, M, flags);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void linearPolar(Mat src, Mat& dst, Point2f center, double maxRadius, int flags)
				//
	
				//javadoc: linearPolar(src, dst, center, maxRadius, flags)
				public static void linearPolar (Mat src, Mat dst, Point center, double maxRadius, int flags)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_linearPolar_10 (src.nativeObj, dst.nativeObj, center.x, center.y, maxRadius, flags);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void integral(Mat src, Mat& sum, int sdepth = -1)
				//
	
				//javadoc: integral(src, sum, sdepth)
				public static void integral (Mat src, Mat sum, int sdepth)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral_10 (src.nativeObj, sum.nativeObj, sdepth);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: integral(src, sum)
				public static void integral (Mat src, Mat sum)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral_11 (src.nativeObj, sum.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, int sdepth = -1, int sqdepth = -1)
				//
	
				//javadoc: integral(src, sum, sqsum, sdepth, sqdepth)
				public static void integral2 (Mat src, Mat sum, Mat sqsum, int sdepth, int sqdepth)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();
						if (sqsum != null)
								sqsum.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral2_10 (src.nativeObj, sum.nativeObj, sqsum.nativeObj, sdepth, sqdepth);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: integral(src, sum, sqsum)
				public static void integral2 (Mat src, Mat sum, Mat sqsum)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (sum != null)
								sum.ThrowIfDisposed ();
						if (sqsum != null)
								sqsum.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_integral2_11 (src.nativeObj, sum.nativeObj, sqsum.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void calcBackProject(vector_Mat images, vector_int channels, Mat hist, Mat& dst, vector_float ranges, double scale)
				//
	
				//javadoc: calcBackProject(images, channels, hist, dst, ranges, scale)
				public static void calcBackProject (List<Mat> images, MatOfInt channels, Mat hist, Mat dst, MatOfFloat ranges, double scale)
				{
						if (channels != null)
								channels.ThrowIfDisposed ();
						if (hist != null)
								hist.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (ranges != null)
								ranges.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat images_mat = Converters.vector_Mat_to_Mat (images);
						Mat channels_mat = channels;
						Mat ranges_mat = ranges;
						imgproc_Imgproc_calcBackProject_10 (images_mat.nativeObj, channels_mat.nativeObj, hist.nativeObj, dst.nativeObj, ranges_mat.nativeObj, scale);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  double compareHist(Mat H1, Mat H2, int method)
				//
	
				//javadoc: compareHist(H1, H2, method)
				public static double compareHist (Mat H1, Mat H2, int method)
				{
						if (H1 != null)
								H1.ThrowIfDisposed ();
						if (H2 != null)
								H2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_compareHist_10 (H1.nativeObj, H2.nativeObj, method);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  void equalizeHist(Mat src, Mat& dst)
				//
	
				//javadoc: equalizeHist(src, dst)
				public static void equalizeHist (Mat src, Mat dst)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_equalizeHist_10 (src.nativeObj, dst.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void watershed(Mat image, Mat& markers)
				//
	
				//javadoc: watershed(image, markers)
				public static void watershed (Mat image, Mat markers)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (markers != null)
								markers.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_watershed_10 (image.nativeObj, markers.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void pyrMeanShiftFiltering(Mat src, Mat& dst, double sp, double sr, int maxLevel = 1, TermCriteria termcrit = TermCriteria(TermCriteria::MAX_ITER+TermCriteria::EPS,5,1))
				//
	
				//javadoc: pyrMeanShiftFiltering(src, dst, sp, sr, maxLevel, termcrit)
				public static void pyrMeanShiftFiltering (Mat src, Mat dst, double sp, double sr, int maxLevel, TermCriteria termcrit)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrMeanShiftFiltering_10 (src.nativeObj, dst.nativeObj, sp, sr, maxLevel, termcrit.type, termcrit.maxCount, termcrit.epsilon);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: pyrMeanShiftFiltering(src, dst, sp, sr)
				public static void pyrMeanShiftFiltering (Mat src, Mat dst, double sp, double sr)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_pyrMeanShiftFiltering_11 (src.nativeObj, dst.nativeObj, sp, sr);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void grabCut(Mat img, Mat& mask, Rect rect, Mat& bgdModel, Mat& fgdModel, int iterCount, int mode = GC_EVAL)
				//
	
				//javadoc: grabCut(img, mask, rect, bgdModel, fgdModel, iterCount, mode)
				public static void grabCut (Mat img, Mat mask, Rect rect, Mat bgdModel, Mat fgdModel, int iterCount, int mode)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						if (bgdModel != null)
								bgdModel.ThrowIfDisposed ();
						if (fgdModel != null)
								fgdModel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_grabCut_10 (img.nativeObj, mask.nativeObj, rect.x, rect.y, rect.width, rect.height, bgdModel.nativeObj, fgdModel.nativeObj, iterCount, mode);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: grabCut(img, mask, rect, bgdModel, fgdModel, iterCount)
				public static void grabCut (Mat img, Mat mask, Rect rect, Mat bgdModel, Mat fgdModel, int iterCount)
				{
						if (img != null)
								img.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();
						if (bgdModel != null)
								bgdModel.ThrowIfDisposed ();
						if (fgdModel != null)
								fgdModel.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_grabCut_11 (img.nativeObj, mask.nativeObj, rect.x, rect.y, rect.width, rect.height, bgdModel.nativeObj, fgdModel.nativeObj, iterCount);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void distanceTransform(Mat src, Mat& dst, Mat& labels, int distanceType, int maskSize, int labelType = DIST_LABEL_CCOMP)
				//
	
				//javadoc: distanceTransform(src, dst, labels, distanceType, maskSize, labelType)
				public static void distanceTransformWithLabels (Mat src, Mat dst, Mat labels, int distanceType, int maskSize, int labelType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_distanceTransformWithLabels_10 (src.nativeObj, dst.nativeObj, labels.nativeObj, distanceType, maskSize, labelType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: distanceTransform(src, dst, labels, distanceType, maskSize)
				public static void distanceTransformWithLabels (Mat src, Mat dst, Mat labels, int distanceType, int maskSize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_distanceTransformWithLabels_11 (src.nativeObj, dst.nativeObj, labels.nativeObj, distanceType, maskSize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void distanceTransform(Mat src, Mat& dst, int distanceType, int maskSize, int dstType = CV_32F)
				//
	
				//javadoc: distanceTransform(src, dst, distanceType, maskSize, dstType)
				public static void distanceTransform (Mat src, Mat dst, int distanceType, int maskSize, int dstType)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_distanceTransform_10 (src.nativeObj, dst.nativeObj, distanceType, maskSize, dstType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: distanceTransform(src, dst, distanceType, maskSize)
				public static void distanceTransform (Mat src, Mat dst, int distanceType, int maskSize)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_distanceTransform_11 (src.nativeObj, dst.nativeObj, distanceType, maskSize);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  int floodFill(Mat& image, Mat& mask, Point seedPoint, Scalar newVal, Rect* rect = 0, Scalar loDiff = Scalar(), Scalar upDiff = Scalar(), int flags = 4)
				//
	
				//javadoc: floodFill(image, mask, seedPoint, newVal, rect, loDiff, upDiff, flags)
				public static int floodFill (Mat image, Mat mask, Point seedPoint, Scalar newVal, Rect rect, Scalar loDiff, Scalar upDiff, int flags)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] rect_out = new double[4];
						int retVal = imgproc_Imgproc_floodFill_10 (image.nativeObj, mask.nativeObj, seedPoint.x, seedPoint.y, newVal.val [0], newVal.val [1], newVal.val [2], newVal.val [3], rect_out, loDiff.val [0], loDiff.val [1], loDiff.val [2], loDiff.val [3], upDiff.val [0], upDiff.val [1], upDiff.val [2], upDiff.val [3], flags);
						if (rect != null) {
								rect.x = (int)rect_out [0];
								rect.y = (int)rect_out [1];
								rect.width = (int)rect_out [2];
								rect.height = (int)rect_out [3];
						} 
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: floodFill(image, mask, seedPoint, newVal)
				public static int floodFill (Mat image, Mat mask, Point seedPoint, Scalar newVal)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_floodFill_11 (image.nativeObj, mask.nativeObj, seedPoint.x, seedPoint.y, newVal.val [0], newVal.val [1], newVal.val [2], newVal.val [3]);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  void cvtColor(Mat src, Mat& dst, int code, int dstCn = 0)
				//
	
				//javadoc: cvtColor(src, dst, code, dstCn)
				public static void cvtColor (Mat src, Mat dst, int code, int dstCn)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cvtColor_10 (src.nativeObj, dst.nativeObj, code, dstCn);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: cvtColor(src, dst, code)
				public static void cvtColor (Mat src, Mat dst, int code)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_cvtColor_11 (src.nativeObj, dst.nativeObj, code);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void demosaicing(Mat _src, Mat& _dst, int code, int dcn = 0)
				//
	
				//javadoc: demosaicing(_src, _dst, code, dcn)
				public static void demosaicing (Mat _src, Mat _dst, int code, int dcn)
				{
						if (_src != null)
								_src.ThrowIfDisposed ();
						if (_dst != null)
								_dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_demosaicing_10 (_src.nativeObj, _dst.nativeObj, code, dcn);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: demosaicing(_src, _dst, code)
				public static void demosaicing (Mat _src, Mat _dst, int code)
				{
						if (_src != null)
								_src.ThrowIfDisposed ();
						if (_dst != null)
								_dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_demosaicing_11 (_src.nativeObj, _dst.nativeObj, code);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  Moments moments(Mat array, bool binaryImage = false)
				//
	
				// Return type 'Moments' is not supported, skipping the function
	
	
				//
				// C++:  void HuMoments(Moments m, Mat& hu)
				//
	
				// Unknown type 'Moments' (I), skipping the function
	
	
				//
				// C++:  void matchTemplate(Mat image, Mat templ, Mat& result, int method, Mat mask = Mat())
				//
	
				//javadoc: matchTemplate(image, templ, result, method, mask)
				public static void matchTemplate (Mat image, Mat templ, Mat result, int method, Mat mask)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (templ != null)
								templ.ThrowIfDisposed ();
						if (result != null)
								result.ThrowIfDisposed ();
						if (mask != null)
								mask.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_matchTemplate_10 (image.nativeObj, templ.nativeObj, result.nativeObj, method, mask.nativeObj);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: matchTemplate(image, templ, result, method)
				public static void matchTemplate (Mat image, Mat templ, Mat result, int method)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (templ != null)
								templ.ThrowIfDisposed ();
						if (result != null)
								result.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_matchTemplate_11 (image.nativeObj, templ.nativeObj, result.nativeObj, method);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  int connectedComponents(Mat image, Mat& labels, int connectivity = 8, int ltype = CV_32S)
				//
	
				//javadoc: connectedComponents(image, labels, connectivity, ltype)
				public static int connectedComponents (Mat image, Mat labels, int connectivity, int ltype)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_connectedComponents_10 (image.nativeObj, labels.nativeObj, connectivity, ltype);
		
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: connectedComponents(image, labels)
				public static int connectedComponents (Mat image, Mat labels)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_connectedComponents_11 (image.nativeObj, labels.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  int connectedComponentsWithStats(Mat image, Mat& labels, Mat& stats, Mat& centroids, int connectivity = 8, int ltype = CV_32S)
				//
	
				//javadoc: connectedComponentsWithStats(image, labels, stats, centroids, connectivity, ltype)
				public static int connectedComponentsWithStats (Mat image, Mat labels, Mat stats, Mat centroids, int connectivity, int ltype)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();
						if (stats != null)
								stats.ThrowIfDisposed ();
						if (centroids != null)
								centroids.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_connectedComponentsWithStats_10 (image.nativeObj, labels.nativeObj, stats.nativeObj, centroids.nativeObj, connectivity, ltype);
		
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: connectedComponentsWithStats(image, labels, stats, centroids)
				public static int connectedComponentsWithStats (Mat image, Mat labels, Mat stats, Mat centroids)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (labels != null)
								labels.ThrowIfDisposed ();
						if (stats != null)
								stats.ThrowIfDisposed ();
						if (centroids != null)
								centroids.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_connectedComponentsWithStats_11 (image.nativeObj, labels.nativeObj, stats.nativeObj, centroids.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  void findContours(Mat& image, vector_vector_Point& contours, Mat& hierarchy, int mode, int method, Point offset = Point())
				//
	
				//javadoc: findContours(image, contours, hierarchy, mode, method, offset)
				public static void findContours (Mat image, List<MatOfPoint> contours, Mat hierarchy, int mode, int method, Point offset)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (hierarchy != null)
								hierarchy.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat contours_mat = new Mat ();
						imgproc_Imgproc_findContours_10 (image.nativeObj, contours_mat.nativeObj, hierarchy.nativeObj, mode, method, offset.x, offset.y);
						Converters.Mat_to_vector_vector_Point (contours_mat, contours);
						contours_mat.release ();
						return;
#else
return;
#endif
				}
	
				//javadoc: findContours(image, contours, hierarchy, mode, method)
				public static void findContours (Mat image, List<MatOfPoint> contours, Mat hierarchy, int mode, int method)
				{
						if (image != null)
								image.ThrowIfDisposed ();
						if (hierarchy != null)
								hierarchy.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat contours_mat = new Mat ();
						imgproc_Imgproc_findContours_11 (image.nativeObj, contours_mat.nativeObj, hierarchy.nativeObj, mode, method);
						Converters.Mat_to_vector_vector_Point (contours_mat, contours);
						contours_mat.release ();
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void approxPolyDP(vector_Point2f curve, vector_Point2f& approxCurve, double epsilon, bool closed)
				//
	
				//javadoc: approxPolyDP(curve, approxCurve, epsilon, closed)
				public static void approxPolyDP (MatOfPoint2f curve, MatOfPoint2f approxCurve, double epsilon, bool closed)
				{
						if (curve != null)
								curve.ThrowIfDisposed ();
						if (approxCurve != null)
								approxCurve.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat curve_mat = curve;
						Mat approxCurve_mat = approxCurve;
						imgproc_Imgproc_approxPolyDP_10 (curve_mat.nativeObj, approxCurve_mat.nativeObj, epsilon, closed);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  double arcLength(vector_Point2f curve, bool closed)
				//
	
				//javadoc: arcLength(curve, closed)
				public static double arcLength (MatOfPoint2f curve, bool closed)
				{
						if (curve != null)
								curve.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat curve_mat = curve;
						double retVal = imgproc_Imgproc_arcLength_10 (curve_mat.nativeObj, closed);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  Rect boundingRect(vector_Point points)
				//
	
				//javadoc: boundingRect(points)
				public static Rect boundingRect (MatOfPoint points)
				{
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] tmpArray = new double[4];
			
						Mat points_mat = points;
			
						imgproc_Imgproc_boundingRect_10 (points_mat.nativeObj, tmpArray);
						Rect retVal = new Rect (tmpArray);
			
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  double contourArea(Mat contour, bool oriented = false)
				//
	
				//javadoc: contourArea(contour, oriented)
				public static double contourArea (Mat contour, bool oriented)
				{
						if (contour != null)
								contour.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_contourArea_10 (contour.nativeObj, oriented);
		
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: contourArea(contour)
				public static double contourArea (Mat contour)
				{
						if (contour != null)
								contour.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_contourArea_11 (contour.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  RotatedRect minAreaRect(vector_Point2f points)
				//
	
				//javadoc: minAreaRect(points)
				public static RotatedRect minAreaRect (MatOfPoint2f points)
				{
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] tmpArray = new double[5];
			
						Mat points_mat = points;
			
						imgproc_Imgproc_minAreaRect_10 (points_mat.nativeObj, tmpArray);
			
						RotatedRect retVal = new RotatedRect (tmpArray);
			
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void boxPoints(RotatedRect box, Mat& points)
				//
	
				//javadoc: boxPoints(box, points)
				public static void boxPoints (RotatedRect box, Mat points)
				{
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_boxPoints_10 (box.center.x, box.center.y, box.size.width, box.size.height, box.angle, points.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void minEnclosingCircle(vector_Point2f points, Point2f& center, float& radius)
				//
	
				//javadoc: minEnclosingCircle(points, center, radius)
				public static void minEnclosingCircle (MatOfPoint2f points, Point center, float[] radius)
				{
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat points_mat = points;
						double[] center_out = new double[2];
						double[] radius_out = new double[1];
						imgproc_Imgproc_minEnclosingCircle_10 (points_mat.nativeObj, center_out, radius_out);
						if (center != null) {
								center.x = center_out [0];
								center.y = center_out [1];
						} 
						if (radius != null)
								radius [0] = (float)radius_out [0];
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  double minEnclosingTriangle(Mat points, Mat& triangle)
				//
	
				//javadoc: minEnclosingTriangle(points, triangle)
				public static double minEnclosingTriangle (Mat points, Mat triangle)
				{
						if (points != null)
								points.ThrowIfDisposed ();
						if (triangle != null)
								triangle.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_minEnclosingTriangle_10 (points.nativeObj, triangle.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  double matchShapes(Mat contour1, Mat contour2, int method, double parameter)
				//
	
				//javadoc: matchShapes(contour1, contour2, method, parameter)
				public static double matchShapes (Mat contour1, Mat contour2, int method, double parameter)
				{
						if (contour1 != null)
								contour1.ThrowIfDisposed ();
						if (contour2 != null)
								contour2.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						double retVal = imgproc_Imgproc_matchShapes_10 (contour1.nativeObj, contour2.nativeObj, method, parameter);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  void convexHull(vector_Point points, vector_int& hull, bool clockwise = false,  _hidden_  returnPoints = true)
				//
	
				//javadoc: convexHull(points, hull, clockwise)
				public static void convexHull (MatOfPoint points, MatOfInt hull, bool clockwise)
				{
						if (points != null)
								points.ThrowIfDisposed ();
						if (hull != null)
								hull.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat points_mat = points;
						Mat hull_mat = hull;
						imgproc_Imgproc_convexHull_10 (points_mat.nativeObj, hull_mat.nativeObj, clockwise);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: convexHull(points, hull)
				public static void convexHull (MatOfPoint points, MatOfInt hull)
				{
						if (points != null)
								points.ThrowIfDisposed ();
						if (hull != null)
								hull.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat points_mat = points;
						Mat hull_mat = hull;
						imgproc_Imgproc_convexHull_11 (points_mat.nativeObj, hull_mat.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void convexityDefects(vector_Point contour, vector_int convexhull, vector_Vec4i& convexityDefects)
				//
	
				//javadoc: convexityDefects(contour, convexhull, convexityDefects)
				public static void convexityDefects (MatOfPoint contour, MatOfInt convexhull, MatOfInt4 convexityDefects)
				{
						if (contour != null)
								contour.ThrowIfDisposed ();
						if (convexhull != null)
								convexhull.ThrowIfDisposed ();
						if (convexityDefects != null)
								convexityDefects.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat contour_mat = contour;
						Mat convexhull_mat = convexhull;
						Mat convexityDefects_mat = convexityDefects;
						imgproc_Imgproc_convexityDefects_10 (contour_mat.nativeObj, convexhull_mat.nativeObj, convexityDefects_mat.nativeObj);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  bool isContourConvex(vector_Point contour)
				//
	
				//javadoc: isContourConvex(contour)
				public static bool isContourConvex (MatOfPoint contour)
				{
						if (contour != null)
								contour.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat contour_mat = contour;
						bool retVal = imgproc_Imgproc_isContourConvex_10 (contour_mat.nativeObj);
		
						return retVal;
#else
return false;
#endif
				}
	
	
				//
				// C++:  float intersectConvexConvex(Mat _p1, Mat _p2, Mat& _p12, bool handleNested = true)
				//
	
				//javadoc: intersectConvexConvex(_p1, _p2, _p12, handleNested)
				public static float intersectConvexConvex (Mat _p1, Mat _p2, Mat _p12, bool handleNested)
				{
						if (_p1 != null)
								_p1.ThrowIfDisposed ();
						if (_p2 != null)
								_p2.ThrowIfDisposed ();
						if (_p12 != null)
								_p12.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						float retVal = imgproc_Imgproc_intersectConvexConvex_10 (_p1.nativeObj, _p2.nativeObj, _p12.nativeObj, handleNested);
		
						return retVal;
#else
return -1;
#endif
				}
	
				//javadoc: intersectConvexConvex(_p1, _p2, _p12)
				public static float intersectConvexConvex (Mat _p1, Mat _p2, Mat _p12)
				{
						if (_p1 != null)
								_p1.ThrowIfDisposed ();
						if (_p2 != null)
								_p2.ThrowIfDisposed ();
						if (_p12 != null)
								_p12.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						float retVal = imgproc_Imgproc_intersectConvexConvex_11 (_p1.nativeObj, _p2.nativeObj, _p12.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  RotatedRect fitEllipse(vector_Point2f points)
				//
	
				//javadoc: fitEllipse(points)
				public static RotatedRect fitEllipse (MatOfPoint2f points)
				{
						if (points != null)
								points.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						double[] tmpArray = new double[5];
			
						Mat points_mat = points;
			
						imgproc_Imgproc_fitEllipse_10 (points_mat.nativeObj, tmpArray);
			
						RotatedRect retVal = new RotatedRect (tmpArray);
			
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void fitLine(Mat points, Mat& line, int distType, double param, double reps, double aeps)
				//
	
				//javadoc: fitLine(points, line, distType, param, reps, aeps)
				public static void fitLine (Mat points, Mat line, int distType, double param, double reps, double aeps)
				{
						if (points != null)
								points.ThrowIfDisposed ();
						if (line != null)
								line.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_fitLine_10 (points.nativeObj, line.nativeObj, distType, param, reps, aeps);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  double pointPolygonTest(vector_Point2f contour, Point2f pt, bool measureDist)
				//
	
				//javadoc: pointPolygonTest(contour, pt, measureDist)
				public static double pointPolygonTest (MatOfPoint2f contour, Point pt, bool measureDist)
				{
						if (contour != null)
								contour.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						Mat contour_mat = contour;
						double retVal = imgproc_Imgproc_pointPolygonTest_10 (contour_mat.nativeObj, pt.x, pt.y, measureDist);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  int rotatedRectangleIntersection(RotatedRect rect1, RotatedRect rect2, Mat& intersectingRegion)
				//
	
				//javadoc: rotatedRectangleIntersection(rect1, rect2, intersectingRegion)
				public static int rotatedRectangleIntersection (RotatedRect rect1, RotatedRect rect2, Mat intersectingRegion)
				{
						if (intersectingRegion != null)
								intersectingRegion.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						int retVal = imgproc_Imgproc_rotatedRectangleIntersection_10 (rect1.center.x, rect1.center.y, rect1.size.width, rect1.size.height, rect1.angle, rect2.center.x, rect2.center.y, rect2.size.width, rect2.size.height, rect2.angle, intersectingRegion.nativeObj);
		
						return retVal;
#else
return -1;
#endif
				}
	
	
				//
				// C++:  Ptr_CLAHE createCLAHE(double clipLimit = 40.0, Size tileGridSize = Size(8, 8))
				//
	
				//javadoc: createCLAHE(clipLimit, tileGridSize)
				public static CLAHE createCLAHE (double clipLimit, Size tileGridSize)
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						CLAHE retVal = new CLAHE (imgproc_Imgproc_createCLAHE_10 (clipLimit, tileGridSize.width, tileGridSize.height));
		
						return retVal;
#else
return null;
#endif
				}
	
				//javadoc: createCLAHE()
				public static CLAHE createCLAHE ()
				{
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						CLAHE retVal = new CLAHE (imgproc_Imgproc_createCLAHE_11 ());
		
						return retVal;
#else
return null;
#endif
				}
	
	
				//
				// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
				//
	
				//javadoc: applyColorMap(src, dst, colormap)
				public static void applyColorMap (Mat src, Mat dst, int colormap)
				{
						if (src != null)
								src.ThrowIfDisposed ();
						if (dst != null)
								dst.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_applyColorMap_10 (src.nativeObj, dst.nativeObj, colormap);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void line(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: line(img, pt1, pt2, color, thickness, lineType, shift)
				public static void line (Mat img, Point pt1, Point pt2, Scalar color, int thickness, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_line_10 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: line(img, pt1, pt2, color, thickness)
				public static void line (Mat img, Point pt1, Point pt2, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_line_11 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: line(img, pt1, pt2, color)
				public static void line (Mat img, Point pt1, Point pt2, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_line_12 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void arrowedLine(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int line_type = 8, int shift = 0, double tipLength = 0.1)
				//
	
				//javadoc: arrowedLine(img, pt1, pt2, color, thickness, line_type, shift, tipLength)
				public static void arrowedLine (Mat img, Point pt1, Point pt2, Scalar color, int thickness, int line_type, int shift, double tipLength)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_arrowedLine_10 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3], thickness, line_type, shift, tipLength);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: arrowedLine(img, pt1, pt2, color)
				public static void arrowedLine (Mat img, Point pt1, Point pt2, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_arrowedLine_11 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void rectangle(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: rectangle(img, pt1, pt2, color, thickness, lineType, shift)
				public static void rectangle (Mat img, Point pt1, Point pt2, Scalar color, int thickness, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_rectangle_10 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: rectangle(img, pt1, pt2, color, thickness)
				public static void rectangle (Mat img, Point pt1, Point pt2, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_rectangle_11 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: rectangle(img, pt1, pt2, color)
				public static void rectangle (Mat img, Point pt1, Point pt2, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_rectangle_12 (img.nativeObj, pt1.x, pt1.y, pt2.x, pt2.y, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void circle(Mat& img, Point center, int radius, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: circle(img, center, radius, color, thickness, lineType, shift)
				public static void circle (Mat img, Point center, int radius, Scalar color, int thickness, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_circle_10 (img.nativeObj, center.x, center.y, radius, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: circle(img, center, radius, color, thickness)
				public static void circle (Mat img, Point center, int radius, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_circle_11 (img.nativeObj, center.x, center.y, radius, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: circle(img, center, radius, color)
				public static void circle (Mat img, Point center, int radius, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_circle_12 (img.nativeObj, center.x, center.y, radius, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void ellipse(Mat& img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				//
	
				//javadoc: ellipse(img, center, axes, angle, startAngle, endAngle, color, thickness, lineType, shift)
				public static void ellipse (Mat img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color, int thickness, int lineType, int shift)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_10 (img.nativeObj, center.x, center.y, axes.width, axes.height, angle, startAngle, endAngle, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType, shift);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: ellipse(img, center, axes, angle, startAngle, endAngle, color, thickness)
				public static void ellipse (Mat img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_11 (img.nativeObj, center.x, center.y, axes.width, axes.height, angle, startAngle, endAngle, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: ellipse(img, center, axes, angle, startAngle, endAngle, color)
				public static void ellipse (Mat img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_12 (img.nativeObj, center.x, center.y, axes.width, axes.height, angle, startAngle, endAngle, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				//
				// C++:  void ellipse(Mat& img, RotatedRect box, Scalar color, int thickness = 1, int lineType = LINE_8)
				//
	
				//javadoc: ellipse(img, box, color, thickness, lineType)
				public static void ellipse (Mat img, RotatedRect box, Scalar color, int thickness, int lineType)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_13 (img.nativeObj, box.center.x, box.center.y, box.size.width, box.size.height, box.angle, color.val [0], color.val [1], color.val [2], color.val [3], thickness, lineType);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: ellipse(img, box, color, thickness)
				public static void ellipse (Mat img, RotatedRect box, Scalar color, int thickness)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_14 (img.nativeObj, box.center.x, box.center.y, box.size.width, box.size.height, box.angle, color.val [0], color.val [1], color.val [2], color.val [3], thickness);
		
						return;
#else
return;
#endif
				}
	
				//javadoc: ellipse(img, box, color)
				public static void ellipse (Mat img, RotatedRect box, Scalar color)
				{
						if (img != null)
								img.ThrowIfDisposed ();

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
		
						imgproc_Imgproc_ellipse_15 (img.nativeObj, box.center.x, box.center.y, box.size.width, box.size.height, box.angle, color.val [0], color.val [1], color.val [2], color.val [3]);
		
						return;
#else
return;
#endif
				}
	
	
				// C++: Size getTextSize(const String& text, int fontFace, double fontScale, int thickness, int* baseLine);
				//javadoc:getTextSize(text, fontFace, fontScale, thickness, baseLine)
				public static Size getTextSize (string text, int fontFace, double fontScale, int thickness, int[] baseLine)
				{
						#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5
						if (baseLine != null && baseLine.Length != 1)
								throw new CvException ("'baseLine' must be 'int[1]' or 'null'.");
						double[] tmpArray = new double[2];
						imgproc_Imgproc_n_1getTextSize (text, fontFace, fontScale, thickness, baseLine, tmpArray);
						Size retVal = new Size (tmpArray);
						return retVal;
						#else
			return null;
						#endif
				}
	
	
		#if UNITY_IOS && !UNITY_EDITOR
		// C++:  Ptr_LineSegmentDetector createLineSegmentDetector(int _refine = LSD_REFINE_STD, double _scale = 0.8, double _sigma_scale = 0.6, double _quant = 2.0, double _ang_th = 22.5, double _log_eps = 0, double _density_th = 0.7, int _n_bins = 1024)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_createLineSegmentDetector_10 (int _refine, double _scale, double _sigma_scale, double _quant, double _ang_th, double _log_eps, double _density_th, int _n_bins);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_createLineSegmentDetector_11 ();
		
		// C++:  Mat getGaussianKernel(int ksize, double sigma, int ktype = CV_64F)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getGaussianKernel_10 (int ksize, double sigma, int ktype);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getGaussianKernel_11 (int ksize, double sigma);
		
		// C++:  void getDerivKernels(Mat& kx, Mat& ky, int dx, int dy, int ksize, bool normalize = false, int ktype = CV_32F)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_getDerivKernels_10 (IntPtr kx_nativeObj, IntPtr ky_nativeObj, int dx, int dy, int ksize, bool normalize, int ktype);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_getDerivKernels_11 (IntPtr kx_nativeObj, IntPtr ky_nativeObj, int dx, int dy, int ksize);
		
		// C++:  Mat getGaborKernel(Size ksize, double sigma, double theta, double lambd, double gamma, double psi = CV_PI*0.5, int ktype = CV_64F)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getGaborKernel_10 (double ksize_width, double ksize_height, double sigma, double theta, double lambd, double gamma, double psi, int ktype);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getGaborKernel_11 (double ksize_width, double ksize_height, double sigma, double theta, double lambd, double gamma);
		
		// C++:  void fillConvexPoly(Mat& img, vector_Point points, Scalar color, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fillConvexPoly_10 (IntPtr img_nativeObj, IntPtr points_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fillConvexPoly_11 (IntPtr img_nativeObj, IntPtr points_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void fillPoly(Mat& img, vector_vector_Point pts, Scalar color, int lineType = LINE_8, int shift = 0, Point offset = Point())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fillPoly_10 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int lineType, int shift, double offset_x, double offset_y);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fillPoly_11 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void polylines(Mat& img, vector_vector_Point pts, bool isClosed, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_polylines_10 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_polylines_11 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_polylines_12 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void drawContours(Mat& image, vector_vector_Point contours, int contourIdx, Scalar color, int thickness = 1, int lineType = LINE_8, Mat hierarchy = Mat(), int maxLevel = INT_MAX, Point offset = Point())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_drawContours_10 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, IntPtr hierarchy_nativeObj, int maxLevel, double offset_x, double offset_y);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_drawContours_11 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_drawContours_12 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  bool clipLine(Rect imgRect, Point& pt1, Point& pt2)
		[DllImport("__Internal")]
		private static extern bool imgproc_Imgproc_clipLine_10 (int imgRect_x, int imgRect_y, int imgRect_width, int imgRect_height, double pt1_x, double pt1_y, double[] pt1_out, double pt2_x, double pt2_y, double[] pt2_out);
		
		// C++:  void ellipse2Poly(Point center, Size axes, int angle, int arcStart, int arcEnd, int delta, vector_Point& pts)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse2Poly_10 (double center_x, double center_y, double axes_width, double axes_height, int angle, int arcStart, int arcEnd, int delta, IntPtr pts_mat_nativeObj);
		
		// C++:  void putText(Mat& img, String text, Point org, int fontFace, double fontScale, Scalar color, int thickness = 1, int lineType = LINE_8, bool bottomLeftOrigin = false)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_putText_10 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, bool bottomLeftOrigin);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_putText_11 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_putText_12 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  Mat getStructuringElement(int shape, Size ksize, Point anchor = Point(-1,-1))
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getStructuringElement_10 (int shape, double ksize_width, double ksize_height, double anchor_x, double anchor_y);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getStructuringElement_11 (int shape, double ksize_width, double ksize_height);
		
		// C++:  void medianBlur(Mat src, Mat& dst, int ksize)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_medianBlur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize);
		
		// C++:  void GaussianBlur(Mat src, Mat& dst, Size ksize, double sigmaX, double sigmaY = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_GaussianBlur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX, double sigmaY, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_GaussianBlur_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX, double sigmaY);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_GaussianBlur_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX);
		
		// C++:  void bilateralFilter(Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_bilateralFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_bilateralFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);
		
		// C++:  void boxFilter(Mat src, Mat& dst, int ddepth, Size ksize, Point anchor = Point(-1,-1), bool normalize = true, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_boxFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_boxFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_boxFilter_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height);
		
		// C++:  void sqrBoxFilter(Mat _src, Mat& _dst, int ddepth, Size ksize, Point anchor = Point(-1, -1), bool normalize = true, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sqrBoxFilter_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sqrBoxFilter_11 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sqrBoxFilter_12 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height);
		
		// C++:  void blur(Mat src, Mat& dst, Size ksize, Point anchor = Point(-1,-1), int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_blur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double anchor_x, double anchor_y, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_blur_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double anchor_x, double anchor_y);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_blur_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height);
		
		// C++:  void filter2D(Mat src, Mat& dst, int ddepth, Mat kernel, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_filter2D_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, double delta, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_filter2D_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, double delta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_filter2D_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj);
		
		// C++:  void sepFilter2D(Mat src, Mat& dst, int ddepth, Mat kernelX, Mat kernelY, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sepFilter2D_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj, double anchor_x, double anchor_y, double delta, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sepFilter2D_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj, double anchor_x, double anchor_y, double delta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_sepFilter2D_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj);
		
		// C++:  void Sobel(Mat src, Mat& dst, int ddepth, int dx, int dy, int ksize = 3, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Sobel_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, int ksize, double scale, double delta, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Sobel_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, int ksize, double scale, double delta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Sobel_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy);
		
		// C++:  void Scharr(Mat src, Mat& dst, int ddepth, int dx, int dy, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Scharr_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, double scale, double delta, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Scharr_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, double scale, double delta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Scharr_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy);
		
		// C++:  void Laplacian(Mat src, Mat& dst, int ddepth, int ksize = 1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Laplacian_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int ksize, double scale, double delta, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Laplacian_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int ksize, double scale, double delta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Laplacian_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth);
		
		// C++:  void Canny(Mat image, Mat& edges, double threshold1, double threshold2, int apertureSize = 3, bool L2gradient = false)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Canny_10 (IntPtr image_nativeObj, IntPtr edges_nativeObj, double threshold1, double threshold2, int apertureSize, bool L2gradient);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_Canny_11 (IntPtr image_nativeObj, IntPtr edges_nativeObj, double threshold1, double threshold2);
		
		// C++:  void cornerMinEigenVal(Mat src, Mat& dst, int blockSize, int ksize = 3, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerMinEigenVal_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerMinEigenVal_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerMinEigenVal_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize);
		
		// C++:  void cornerHarris(Mat src, Mat& dst, int blockSize, int ksize, double k, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerHarris_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, double k, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerHarris_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, double k);
		
		// C++:  void cornerEigenValsAndVecs(Mat src, Mat& dst, int blockSize, int ksize, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerEigenValsAndVecs_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerEigenValsAndVecs_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize);
		
		// C++:  void preCornerDetect(Mat src, Mat& dst, int ksize, int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_preCornerDetect_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_preCornerDetect_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize);
		
		// C++:  void cornerSubPix(Mat image, vector_Point2f& corners, Size winSize, Size zeroZone, TermCriteria criteria)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cornerSubPix_10 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, double winSize_width, double winSize_height, double zeroZone_width, double zeroZone_height, int criteria_type, int criteria_maxCount, double criteria_epsilon);
		
		// C++:  void goodFeaturesToTrack(Mat image, vector_Point& corners, int maxCorners, double qualityLevel, double minDistance, Mat mask = Mat(), int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_goodFeaturesToTrack_10 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, int maxCorners, double qualityLevel, double minDistance, IntPtr mask_nativeObj, int blockSize, bool useHarrisDetector, double k);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_goodFeaturesToTrack_11 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, int maxCorners, double qualityLevel, double minDistance);
		
		// C++:  void HoughLines(Mat image, Mat& lines, double rho, double theta, int threshold, double srn = 0, double stn = 0, double min_theta = 0, double max_theta = CV_PI)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughLines_10 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughLines_11 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold);
		
		// C++:  void HoughLinesP(Mat image, Mat& lines, double rho, double theta, int threshold, double minLineLength = 0, double maxLineGap = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughLinesP_10 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold, double minLineLength, double maxLineGap);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughLinesP_11 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold);
		
		// C++:  void HoughCircles(Mat image, Mat& circles, int method, double dp, double minDist, double param1 = 100, double param2 = 100, int minRadius = 0, int maxRadius = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughCircles_10 (IntPtr image_nativeObj, IntPtr circles_nativeObj, int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_HoughCircles_11 (IntPtr image_nativeObj, IntPtr circles_nativeObj, int method, double dp, double minDist);
		
		// C++:  void erode(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_erode_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_erode_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_erode_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj);
		
		// C++:  void dilate(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_dilate_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_dilate_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_dilate_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj);
		
		// C++:  void morphologyEx(Mat src, Mat& dst, int op, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_morphologyEx_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_morphologyEx_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_morphologyEx_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj);
		
		// C++:  void resize(Mat src, Mat& dst, Size dsize, double fx = 0, double fy = 0, int interpolation = INTER_LINEAR)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_resize_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dsize_width, double dsize_height, double fx, double fy, int interpolation);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_resize_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dsize_width, double dsize_height);
		
		// C++:  void warpAffine(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpAffine_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpAffine_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpAffine_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height);
		
		// C++:  void warpPerspective(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpPerspective_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpPerspective_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_warpPerspective_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height);
		
		// C++:  void remap(Mat src, Mat& dst, Mat map1, Mat map2, int interpolation, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_remap_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int interpolation, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_remap_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int interpolation);
		
		// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, Mat& tilted, int sdepth = -1, int sqdepth = -1)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral3_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, IntPtr tilted_nativeObj, int sdepth, int sqdepth);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral3_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, IntPtr tilted_nativeObj);
		
		// C++:  void accumulate(Mat src, Mat& dst, Mat mask = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulate_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulate_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void accumulateSquare(Mat src, Mat& dst, Mat mask = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateSquare_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateSquare_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void accumulateProduct(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateProduct_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateProduct_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void accumulateWeighted(Mat src, Mat& dst, double alpha, Mat mask = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateWeighted_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, IntPtr mask_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_accumulateWeighted_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha);
		
		// C++:  Point2d phaseCorrelate(Mat src1, Mat src2, Mat window = Mat(), double* response = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_phaseCorrelate_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr window_nativeObj, double[] response_out, double[] vals);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_phaseCorrelate_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, double[] vals);
		
		// C++:  void createHanningWindow(Mat& dst, Size winSize, int type)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_createHanningWindow_10 (IntPtr dst_nativeObj, double winSize_width, double winSize_height, int type);
		
		// C++:  double threshold(Mat src, Mat& dst, double thresh, double maxval, int type)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_threshold_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double thresh, double maxval, int type);
		
		// C++:  void adaptiveThreshold(Mat src, Mat& dst, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_adaptiveThreshold_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C);
		
		// C++:  void pyrDown(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrDown_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrDown_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrDown_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void pyrUp(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrUp_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height, int borderType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrUp_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrUp_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_undistort_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr newCameraMatrix_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_undistort_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
		
		// C++:  void initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_initUndistortRectifyMap_10 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr newCameraMatrix_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);
		
		// C++:  float initWideAngleProjMap(Mat cameraMatrix, Mat distCoeffs, Size imageSize, int destImageWidth, int m1type, Mat& map1, Mat& map2, int projType = PROJ_SPHERICAL_EQRECT, double alpha = 0)
		[DllImport("__Internal")]
		private static extern float imgproc_Imgproc_initWideAngleProjMap_10 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, int destImageWidth, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int projType, double alpha);
		
		[DllImport("__Internal")]
		private static extern float imgproc_Imgproc_initWideAngleProjMap_11 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, int destImageWidth, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);
		
		// C++:  Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getDefaultNewCameraMatrix_10 (IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height, bool centerPrincipalPoint);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getDefaultNewCameraMatrix_11 (IntPtr cameraMatrix_nativeObj);
		
		// C++:  void undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_undistortPoints_10 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_undistortPoints_11 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
		
		// C++:  void calcHist(vector_Mat images, vector_int channels, Mat mask, Mat& hist, vector_int histSize, vector_float ranges, bool accumulate = false)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_calcHist_10 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr mask_nativeObj, IntPtr hist_nativeObj, IntPtr histSize_mat_nativeObj, IntPtr ranges_mat_nativeObj, bool accumulate);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_calcHist_11 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr mask_nativeObj, IntPtr hist_nativeObj, IntPtr histSize_mat_nativeObj, IntPtr ranges_mat_nativeObj);
		
		// C++:  void convertMaps(Mat map1, Mat map2, Mat& dstmap1, Mat& dstmap2, int dstmap1type, bool nninterpolation = false)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_convertMaps_10 (IntPtr map1_nativeObj, IntPtr map2_nativeObj, IntPtr dstmap1_nativeObj, IntPtr dstmap2_nativeObj, int dstmap1type, bool nninterpolation);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_convertMaps_11 (IntPtr map1_nativeObj, IntPtr map2_nativeObj, IntPtr dstmap1_nativeObj, IntPtr dstmap2_nativeObj, int dstmap1type);
		
		// C++:  Mat getRotationMatrix2D(Point2f center, double angle, double scale)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getRotationMatrix2D_10 (double center_x, double center_y, double angle, double scale);
		
		// C++:  void invertAffineTransform(Mat M, Mat& iM)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_invertAffineTransform_10 (IntPtr M_nativeObj, IntPtr iM_nativeObj);
		
		// C++:  Mat getPerspectiveTransform(Mat src, Mat dst)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getPerspectiveTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  Mat getAffineTransform(vector_Point2f src, vector_Point2f dst)
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_getAffineTransform_10 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj);
		
		// C++:  void getRectSubPix(Mat image, Size patchSize, Point2f center, Mat& patch, int patchType = -1)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_getRectSubPix_10 (IntPtr image_nativeObj, double patchSize_width, double patchSize_height, double center_x, double center_y, IntPtr patch_nativeObj, int patchType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_getRectSubPix_11 (IntPtr image_nativeObj, double patchSize_width, double patchSize_height, double center_x, double center_y, IntPtr patch_nativeObj);
		
		// C++:  void logPolar(Mat src, Mat& dst, Point2f center, double M, int flags)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_logPolar_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double center_x, double center_y, double M, int flags);
		
		// C++:  void linearPolar(Mat src, Mat& dst, Point2f center, double maxRadius, int flags)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_linearPolar_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double center_x, double center_y, double maxRadius, int flags);
		
		// C++:  void integral(Mat src, Mat& sum, int sdepth = -1)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, int sdepth);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj);
		
		// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, int sdepth = -1, int sqdepth = -1)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral2_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, int sdepth, int sqdepth);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_integral2_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj);
		
		// C++:  void calcBackProject(vector_Mat images, vector_int channels, Mat hist, Mat& dst, vector_float ranges, double scale)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_calcBackProject_10 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr hist_nativeObj, IntPtr dst_nativeObj, IntPtr ranges_mat_nativeObj, double scale);
		
		// C++:  double compareHist(Mat H1, Mat H2, int method)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_compareHist_10 (IntPtr H1_nativeObj, IntPtr H2_nativeObj, int method);
		
		// C++:  void equalizeHist(Mat src, Mat& dst)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_equalizeHist_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
		
		// C++:  void watershed(Mat image, Mat& markers)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_watershed_10 (IntPtr image_nativeObj, IntPtr markers_nativeObj);
		
		// C++:  void pyrMeanShiftFiltering(Mat src, Mat& dst, double sp, double sr, int maxLevel = 1, TermCriteria termcrit = TermCriteria(TermCriteria::MAX_ITER+TermCriteria::EPS,5,1))
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrMeanShiftFiltering_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sp, double sr, int maxLevel, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_pyrMeanShiftFiltering_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sp, double sr);
		
		// C++:  void grabCut(Mat img, Mat& mask, Rect rect, Mat& bgdModel, Mat& fgdModel, int iterCount, int mode = GC_EVAL)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_grabCut_10 (IntPtr img_nativeObj, IntPtr mask_nativeObj, int rect_x, int rect_y, int rect_width, int rect_height, IntPtr bgdModel_nativeObj, IntPtr fgdModel_nativeObj, int iterCount, int mode);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_grabCut_11 (IntPtr img_nativeObj, IntPtr mask_nativeObj, int rect_x, int rect_y, int rect_width, int rect_height, IntPtr bgdModel_nativeObj, IntPtr fgdModel_nativeObj, int iterCount);
		
		// C++:  void distanceTransform(Mat src, Mat& dst, Mat& labels, int distanceType, int maskSize, int labelType = DIST_LABEL_CCOMP)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_distanceTransformWithLabels_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr labels_nativeObj, int distanceType, int maskSize, int labelType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_distanceTransformWithLabels_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr labels_nativeObj, int distanceType, int maskSize);
		
		// C++:  void distanceTransform(Mat src, Mat& dst, int distanceType, int maskSize, int dstType = CV_32F)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_distanceTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int distanceType, int maskSize, int dstType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_distanceTransform_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int distanceType, int maskSize);
		
		// C++:  int floodFill(Mat& image, Mat& mask, Point seedPoint, Scalar newVal, Rect* rect = 0, Scalar loDiff = Scalar(), Scalar upDiff = Scalar(), int flags = 4)
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_floodFill_10 (IntPtr image_nativeObj, IntPtr mask_nativeObj, double seedPoint_x, double seedPoint_y, double newVal_val0, double newVal_val1, double newVal_val2, double newVal_val3, double[] rect_out, double loDiff_val0, double loDiff_val1, double loDiff_val2, double loDiff_val3, double upDiff_val0, double upDiff_val1, double upDiff_val2, double upDiff_val3, int flags);
		
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_floodFill_11 (IntPtr image_nativeObj, IntPtr mask_nativeObj, double seedPoint_x, double seedPoint_y, double newVal_val0, double newVal_val1, double newVal_val2, double newVal_val3);
		
		// C++:  void cvtColor(Mat src, Mat& dst, int code, int dstCn = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cvtColor_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int code, int dstCn);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_cvtColor_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int code);
		
		// C++:  void demosaicing(Mat _src, Mat& _dst, int code, int dcn = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_demosaicing_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int code, int dcn);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_demosaicing_11 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int code);
		
		// C++:  void matchTemplate(Mat image, Mat templ, Mat& result, int method, Mat mask = Mat())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_matchTemplate_10 (IntPtr image_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj, int method, IntPtr mask_nativeObj);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_matchTemplate_11 (IntPtr image_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj, int method);
		
		// C++:  int connectedComponents(Mat image, Mat& labels, int connectivity = 8, int ltype = CV_32S)
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_connectedComponents_10 (IntPtr image_nativeObj, IntPtr labels_nativeObj, int connectivity, int ltype);
		
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_connectedComponents_11 (IntPtr image_nativeObj, IntPtr labels_nativeObj);
		
		// C++:  int connectedComponentsWithStats(Mat image, Mat& labels, Mat& stats, Mat& centroids, int connectivity = 8, int ltype = CV_32S)
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_connectedComponentsWithStats_10 (IntPtr image_nativeObj, IntPtr labels_nativeObj, IntPtr stats_nativeObj, IntPtr centroids_nativeObj, int connectivity, int ltype);
		
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_connectedComponentsWithStats_11 (IntPtr image_nativeObj, IntPtr labels_nativeObj, IntPtr stats_nativeObj, IntPtr centroids_nativeObj);
		
		// C++:  void findContours(Mat& image, vector_vector_Point& contours, Mat& hierarchy, int mode, int method, Point offset = Point())
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_findContours_10 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, IntPtr hierarchy_nativeObj, int mode, int method, double offset_x, double offset_y);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_findContours_11 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, IntPtr hierarchy_nativeObj, int mode, int method);
		
		// C++:  void approxPolyDP(vector_Point2f curve, vector_Point2f& approxCurve, double epsilon, bool closed)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_approxPolyDP_10 (IntPtr curve_mat_nativeObj, IntPtr approxCurve_mat_nativeObj, double epsilon, bool closed);
		
		// C++:  double arcLength(vector_Point2f curve, bool closed)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_arcLength_10 (IntPtr curve_mat_nativeObj, bool closed);
		
		// C++:  Rect boundingRect(vector_Point points)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_boundingRect_10 (IntPtr points_mat_nativeObj, double[] vals);
		
		// C++:  double contourArea(Mat contour, bool oriented = false)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_contourArea_10 (IntPtr contour_nativeObj, bool oriented);
		
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_contourArea_11 (IntPtr contour_nativeObj);
		
		// C++:  RotatedRect minAreaRect(vector_Point2f points)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_minAreaRect_10 (IntPtr points_mat_nativeObj, double[] vals);
		
		// C++:  void boxPoints(RotatedRect box, Mat& points)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_boxPoints_10 (double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, IntPtr points_nativeObj);
		
		// C++:  void minEnclosingCircle(vector_Point2f points, Point2f& center, float& radius)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_minEnclosingCircle_10 (IntPtr points_mat_nativeObj, double[] center_out, double[] radius_out);
		
		// C++:  double minEnclosingTriangle(Mat points, Mat& triangle)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_minEnclosingTriangle_10 (IntPtr points_nativeObj, IntPtr triangle_nativeObj);
		
		// C++:  double matchShapes(Mat contour1, Mat contour2, int method, double parameter)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_matchShapes_10 (IntPtr contour1_nativeObj, IntPtr contour2_nativeObj, int method, double parameter);
		
		// C++:  void convexHull(vector_Point points, vector_int& hull, bool clockwise = false,  _hidden_  returnPoints = true)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_convexHull_10 (IntPtr points_mat_nativeObj, IntPtr hull_mat_nativeObj, bool clockwise);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_convexHull_11 (IntPtr points_mat_nativeObj, IntPtr hull_mat_nativeObj);
		
		// C++:  void convexityDefects(vector_Point contour, vector_int convexhull, vector_Vec4i& convexityDefects)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_convexityDefects_10 (IntPtr contour_mat_nativeObj, IntPtr convexhull_mat_nativeObj, IntPtr convexityDefects_mat_nativeObj);
		
		// C++:  bool isContourConvex(vector_Point contour)
		[DllImport("__Internal")]
		private static extern bool imgproc_Imgproc_isContourConvex_10 (IntPtr contour_mat_nativeObj);
		
		// C++:  float intersectConvexConvex(Mat _p1, Mat _p2, Mat& _p12, bool handleNested = true)
		[DllImport("__Internal")]
		private static extern float imgproc_Imgproc_intersectConvexConvex_10 (IntPtr _p1_nativeObj, IntPtr _p2_nativeObj, IntPtr _p12_nativeObj, bool handleNested);
		
		[DllImport("__Internal")]
		private static extern float imgproc_Imgproc_intersectConvexConvex_11 (IntPtr _p1_nativeObj, IntPtr _p2_nativeObj, IntPtr _p12_nativeObj);
		
		// C++:  RotatedRect fitEllipse(vector_Point2f points)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fitEllipse_10 (IntPtr points_mat_nativeObj, double[] vals);
		
		// C++:  void fitLine(Mat points, Mat& line, int distType, double param, double reps, double aeps)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_fitLine_10 (IntPtr points_nativeObj, IntPtr line_nativeObj, int distType, double param, double reps, double aeps);
		
		// C++:  double pointPolygonTest(vector_Point2f contour, Point2f pt, bool measureDist)
		[DllImport("__Internal")]
		private static extern double imgproc_Imgproc_pointPolygonTest_10 (IntPtr contour_mat_nativeObj, double pt_x, double pt_y, bool measureDist);
		
		// C++:  int rotatedRectangleIntersection(RotatedRect rect1, RotatedRect rect2, Mat& intersectingRegion)
		[DllImport("__Internal")]
		private static extern int imgproc_Imgproc_rotatedRectangleIntersection_10 (double rect1_center_x, double rect1_center_y, double rect1_size_width, double rect1_size_height, double rect1_angle, double rect2_center_x, double rect2_center_y, double rect2_size_width, double rect2_size_height, double rect2_angle, IntPtr intersectingRegion_nativeObj);
		
		// C++:  Ptr_CLAHE createCLAHE(double clipLimit = 40.0, Size tileGridSize = Size(8, 8))
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_createCLAHE_10 (double clipLimit, double tileGridSize_width, double tileGridSize_height);
		
		[DllImport("__Internal")]
		private static extern IntPtr imgproc_Imgproc_createCLAHE_11 ();
		
		// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_applyColorMap_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int colormap);
		
		// C++:  void line(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_line_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_line_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_line_12 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void arrowedLine(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int line_type = 8, int shift = 0, double tipLength = 0.1)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_arrowedLine_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int line_type, int shift, double tipLength);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_arrowedLine_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void rectangle(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_rectangle_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_rectangle_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_rectangle_12 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void circle(Mat& img, Point center, int radius, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_circle_10 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_circle_11 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_circle_12 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void ellipse(Mat& img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_10 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_11 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_12 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3);
		
		// C++:  void ellipse(Mat& img, RotatedRect box, Scalar color, int thickness = 1, int lineType = LINE_8)
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_13 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_14 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_ellipse_15 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3);
		
		[DllImport("__Internal")]
		private static extern void imgproc_Imgproc_n_1getTextSize (string text, int fontFace, double fontScale, int thickness, int[] baseLine, double[] vals);
#else
				// C++:  Ptr_LineSegmentDetector createLineSegmentDetector(int _refine = LSD_REFINE_STD, double _scale = 0.8, double _sigma_scale = 0.6, double _quant = 2.0, double _ang_th = 22.5, double _log_eps = 0, double _density_th = 0.7, int _n_bins = 1024)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_createLineSegmentDetector_10 (int _refine, double _scale, double _sigma_scale, double _quant, double _ang_th, double _log_eps, double _density_th, int _n_bins);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_createLineSegmentDetector_11 ();
	
				// C++:  Mat getGaussianKernel(int ksize, double sigma, int ktype = CV_64F)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getGaussianKernel_10 (int ksize, double sigma, int ktype);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getGaussianKernel_11 (int ksize, double sigma);
	
				// C++:  void getDerivKernels(Mat& kx, Mat& ky, int dx, int dy, int ksize, bool normalize = false, int ktype = CV_32F)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_getDerivKernels_10 (IntPtr kx_nativeObj, IntPtr ky_nativeObj, int dx, int dy, int ksize, bool normalize, int ktype);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_getDerivKernels_11 (IntPtr kx_nativeObj, IntPtr ky_nativeObj, int dx, int dy, int ksize);
	
				// C++:  Mat getGaborKernel(Size ksize, double sigma, double theta, double lambd, double gamma, double psi = CV_PI*0.5, int ktype = CV_64F)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getGaborKernel_10 (double ksize_width, double ksize_height, double sigma, double theta, double lambd, double gamma, double psi, int ktype);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getGaborKernel_11 (double ksize_width, double ksize_height, double sigma, double theta, double lambd, double gamma);
	
				// C++:  void fillConvexPoly(Mat& img, vector_Point points, Scalar color, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fillConvexPoly_10 (IntPtr img_nativeObj, IntPtr points_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fillConvexPoly_11 (IntPtr img_nativeObj, IntPtr points_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void fillPoly(Mat& img, vector_vector_Point pts, Scalar color, int lineType = LINE_8, int shift = 0, Point offset = Point())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fillPoly_10 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3, int lineType, int shift, double offset_x, double offset_y);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fillPoly_11 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void polylines(Mat& img, vector_vector_Point pts, bool isClosed, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_polylines_10 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_polylines_11 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_polylines_12 (IntPtr img_nativeObj, IntPtr pts_mat_nativeObj, bool isClosed, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void drawContours(Mat& image, vector_vector_Point contours, int contourIdx, Scalar color, int thickness = 1, int lineType = LINE_8, Mat hierarchy = Mat(), int maxLevel = INT_MAX, Point offset = Point())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_drawContours_10 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, IntPtr hierarchy_nativeObj, int maxLevel, double offset_x, double offset_y);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_drawContours_11 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_drawContours_12 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, int contourIdx, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  bool clipLine(Rect imgRect, Point& pt1, Point& pt2)
				[DllImport("opencvforunity")]
				private static extern bool imgproc_Imgproc_clipLine_10 (int imgRect_x, int imgRect_y, int imgRect_width, int imgRect_height, double pt1_x, double pt1_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] pt1_out, double pt2_x, double pt2_y, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] pt2_out);
	
				// C++:  void ellipse2Poly(Point center, Size axes, int angle, int arcStart, int arcEnd, int delta, vector_Point& pts)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse2Poly_10 (double center_x, double center_y, double axes_width, double axes_height, int angle, int arcStart, int arcEnd, int delta, IntPtr pts_mat_nativeObj);
	
				// C++:  void putText(Mat& img, String text, Point org, int fontFace, double fontScale, Scalar color, int thickness = 1, int lineType = LINE_8, bool bottomLeftOrigin = false)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_putText_10 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, bool bottomLeftOrigin);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_putText_11 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_putText_12 (IntPtr img_nativeObj, string text, double org_x, double org_y, int fontFace, double fontScale, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  Mat getStructuringElement(int shape, Size ksize, Point anchor = Point(-1,-1))
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getStructuringElement_10 (int shape, double ksize_width, double ksize_height, double anchor_x, double anchor_y);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getStructuringElement_11 (int shape, double ksize_width, double ksize_height);
	
				// C++:  void medianBlur(Mat src, Mat& dst, int ksize)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_medianBlur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize);
	
				// C++:  void GaussianBlur(Mat src, Mat& dst, Size ksize, double sigmaX, double sigmaY = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_GaussianBlur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX, double sigmaY, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_GaussianBlur_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX, double sigmaY);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_GaussianBlur_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double sigmaX);
	
				// C++:  void bilateralFilter(Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_bilateralFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_bilateralFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);
	
				// C++:  void boxFilter(Mat src, Mat& dst, int ddepth, Size ksize, Point anchor = Point(-1,-1), bool normalize = true, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_boxFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_boxFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_boxFilter_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, double ksize_width, double ksize_height);
	
				// C++:  void sqrBoxFilter(Mat _src, Mat& _dst, int ddepth, Size ksize, Point anchor = Point(-1, -1), bool normalize = true, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sqrBoxFilter_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sqrBoxFilter_11 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height, double anchor_x, double anchor_y, bool normalize);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sqrBoxFilter_12 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int ddepth, double ksize_width, double ksize_height);
	
				// C++:  void blur(Mat src, Mat& dst, Size ksize, Point anchor = Point(-1,-1), int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_blur_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double anchor_x, double anchor_y, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_blur_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height, double anchor_x, double anchor_y);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_blur_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double ksize_width, double ksize_height);
	
				// C++:  void filter2D(Mat src, Mat& dst, int ddepth, Mat kernel, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_filter2D_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, double delta, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_filter2D_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, double delta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_filter2D_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernel_nativeObj);
	
				// C++:  void sepFilter2D(Mat src, Mat& dst, int ddepth, Mat kernelX, Mat kernelY, Point anchor = Point(-1,-1), double delta = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sepFilter2D_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj, double anchor_x, double anchor_y, double delta, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sepFilter2D_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj, double anchor_x, double anchor_y, double delta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_sepFilter2D_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, IntPtr kernelX_nativeObj, IntPtr kernelY_nativeObj);
	
				// C++:  void Sobel(Mat src, Mat& dst, int ddepth, int dx, int dy, int ksize = 3, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Sobel_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, int ksize, double scale, double delta, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Sobel_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, int ksize, double scale, double delta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Sobel_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy);
	
				// C++:  void Scharr(Mat src, Mat& dst, int ddepth, int dx, int dy, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Scharr_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, double scale, double delta, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Scharr_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy, double scale, double delta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Scharr_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int dx, int dy);
	
				// C++:  void Laplacian(Mat src, Mat& dst, int ddepth, int ksize = 1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Laplacian_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int ksize, double scale, double delta, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Laplacian_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth, int ksize, double scale, double delta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Laplacian_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ddepth);
	
				// C++:  void Canny(Mat image, Mat& edges, double threshold1, double threshold2, int apertureSize = 3, bool L2gradient = false)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Canny_10 (IntPtr image_nativeObj, IntPtr edges_nativeObj, double threshold1, double threshold2, int apertureSize, bool L2gradient);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_Canny_11 (IntPtr image_nativeObj, IntPtr edges_nativeObj, double threshold1, double threshold2);
	
				// C++:  void cornerMinEigenVal(Mat src, Mat& dst, int blockSize, int ksize = 3, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerMinEigenVal_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerMinEigenVal_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerMinEigenVal_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize);
	
				// C++:  void cornerHarris(Mat src, Mat& dst, int blockSize, int ksize, double k, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerHarris_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, double k, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerHarris_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, double k);
	
				// C++:  void cornerEigenValsAndVecs(Mat src, Mat& dst, int blockSize, int ksize, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerEigenValsAndVecs_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerEigenValsAndVecs_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int blockSize, int ksize);
	
				// C++:  void preCornerDetect(Mat src, Mat& dst, int ksize, int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_preCornerDetect_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_preCornerDetect_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int ksize);
	
				// C++:  void cornerSubPix(Mat image, vector_Point2f& corners, Size winSize, Size zeroZone, TermCriteria criteria)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cornerSubPix_10 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, double winSize_width, double winSize_height, double zeroZone_width, double zeroZone_height, int criteria_type, int criteria_maxCount, double criteria_epsilon);
	
				// C++:  void goodFeaturesToTrack(Mat image, vector_Point& corners, int maxCorners, double qualityLevel, double minDistance, Mat mask = Mat(), int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_goodFeaturesToTrack_10 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, int maxCorners, double qualityLevel, double minDistance, IntPtr mask_nativeObj, int blockSize, bool useHarrisDetector, double k);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_goodFeaturesToTrack_11 (IntPtr image_nativeObj, IntPtr corners_mat_nativeObj, int maxCorners, double qualityLevel, double minDistance);
	
				// C++:  void HoughLines(Mat image, Mat& lines, double rho, double theta, int threshold, double srn = 0, double stn = 0, double min_theta = 0, double max_theta = CV_PI)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughLines_10 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold, double srn, double stn, double min_theta, double max_theta);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughLines_11 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold);
	
				// C++:  void HoughLinesP(Mat image, Mat& lines, double rho, double theta, int threshold, double minLineLength = 0, double maxLineGap = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughLinesP_10 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold, double minLineLength, double maxLineGap);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughLinesP_11 (IntPtr image_nativeObj, IntPtr lines_nativeObj, double rho, double theta, int threshold);
	
				// C++:  void HoughCircles(Mat image, Mat& circles, int method, double dp, double minDist, double param1 = 100, double param2 = 100, int minRadius = 0, int maxRadius = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughCircles_10 (IntPtr image_nativeObj, IntPtr circles_nativeObj, int method, double dp, double minDist, double param1, double param2, int minRadius, int maxRadius);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_HoughCircles_11 (IntPtr image_nativeObj, IntPtr circles_nativeObj, int method, double dp, double minDist);
	
				// C++:  void erode(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_erode_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_erode_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_erode_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj);
	
				// C++:  void dilate(Mat src, Mat& dst, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_dilate_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_dilate_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_dilate_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr kernel_nativeObj);
	
				// C++:  void morphologyEx(Mat src, Mat& dst, int op, Mat kernel, Point anchor = Point(-1,-1), int iterations = 1, int borderType = BORDER_CONSTANT, Scalar borderValue = morphologyDefaultBorderValue())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_morphologyEx_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations, int borderType, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_morphologyEx_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj, double anchor_x, double anchor_y, int iterations);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_morphologyEx_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int op, IntPtr kernel_nativeObj);
	
				// C++:  void resize(Mat src, Mat& dst, Size dsize, double fx = 0, double fy = 0, int interpolation = INTER_LINEAR)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_resize_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dsize_width, double dsize_height, double fx, double fy, int interpolation);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_resize_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dsize_width, double dsize_height);
	
				// C++:  void warpAffine(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpAffine_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpAffine_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpAffine_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height);
	
				// C++:  void warpPerspective(Mat src, Mat& dst, Mat M, Size dsize, int flags = INTER_LINEAR, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpPerspective_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpPerspective_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height, int flags);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_warpPerspective_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr M_nativeObj, double dsize_width, double dsize_height);
	
				// C++:  void remap(Mat src, Mat& dst, Mat map1, Mat map2, int interpolation, int borderMode = BORDER_CONSTANT, Scalar borderValue = Scalar())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_remap_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int interpolation, int borderMode, double borderValue_val0, double borderValue_val1, double borderValue_val2, double borderValue_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_remap_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int interpolation);
	
				// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, Mat& tilted, int sdepth = -1, int sqdepth = -1)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral3_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, IntPtr tilted_nativeObj, int sdepth, int sqdepth);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral3_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, IntPtr tilted_nativeObj);
	
				// C++:  void accumulate(Mat src, Mat& dst, Mat mask = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulate_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulate_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void accumulateSquare(Mat src, Mat& dst, Mat mask = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateSquare_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateSquare_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void accumulateProduct(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateProduct_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateProduct_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void accumulateWeighted(Mat src, Mat& dst, double alpha, Mat mask = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateWeighted_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, IntPtr mask_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_accumulateWeighted_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha);
	
				// C++:  Point2d phaseCorrelate(Mat src1, Mat src2, Mat window = Mat(), double* response = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_phaseCorrelate_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr window_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] response_out, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_phaseCorrelate_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
	
				// C++:  void createHanningWindow(Mat& dst, Size winSize, int type)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_createHanningWindow_10 (IntPtr dst_nativeObj, double winSize_width, double winSize_height, int type);
	
				// C++:  double threshold(Mat src, Mat& dst, double thresh, double maxval, int type)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_threshold_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double thresh, double maxval, int type);
	
				// C++:  void adaptiveThreshold(Mat src, Mat& dst, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_adaptiveThreshold_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double maxValue, int adaptiveMethod, int thresholdType, int blockSize, double C);
	
				// C++:  void pyrDown(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrDown_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrDown_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrDown_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void pyrUp(Mat src, Mat& dst, Size dstsize = Size(), int borderType = BORDER_DEFAULT)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrUp_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height, int borderType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrUp_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double dstsize_width, double dstsize_height);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrUp_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void undistort(Mat src, Mat& dst, Mat cameraMatrix, Mat distCoeffs, Mat newCameraMatrix = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_undistort_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr newCameraMatrix_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_undistort_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
	
				// C++:  void initUndistortRectifyMap(Mat cameraMatrix, Mat distCoeffs, Mat R, Mat newCameraMatrix, Size size, int m1type, Mat& map1, Mat& map2)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_initUndistortRectifyMap_10 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr newCameraMatrix_nativeObj, double size_width, double size_height, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);
	
				// C++:  float initWideAngleProjMap(Mat cameraMatrix, Mat distCoeffs, Size imageSize, int destImageWidth, int m1type, Mat& map1, Mat& map2, int projType = PROJ_SPHERICAL_EQRECT, double alpha = 0)
				[DllImport("opencvforunity")]
				private static extern float imgproc_Imgproc_initWideAngleProjMap_10 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, int destImageWidth, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj, int projType, double alpha);

				[DllImport("opencvforunity")]
				private static extern float imgproc_Imgproc_initWideAngleProjMap_11 (IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, double imageSize_width, double imageSize_height, int destImageWidth, int m1type, IntPtr map1_nativeObj, IntPtr map2_nativeObj);
	
				// C++:  Mat getDefaultNewCameraMatrix(Mat cameraMatrix, Size imgsize = Size(), bool centerPrincipalPoint = false)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getDefaultNewCameraMatrix_10 (IntPtr cameraMatrix_nativeObj, double imgsize_width, double imgsize_height, bool centerPrincipalPoint);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getDefaultNewCameraMatrix_11 (IntPtr cameraMatrix_nativeObj);
	
				// C++:  void undistortPoints(vector_Point2f src, vector_Point2f& dst, Mat cameraMatrix, Mat distCoeffs, Mat R = Mat(), Mat P = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_undistortPoints_10 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj, IntPtr R_nativeObj, IntPtr P_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_undistortPoints_11 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr cameraMatrix_nativeObj, IntPtr distCoeffs_nativeObj);
	
				// C++:  void calcHist(vector_Mat images, vector_int channels, Mat mask, Mat& hist, vector_int histSize, vector_float ranges, bool accumulate = false)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_calcHist_10 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr mask_nativeObj, IntPtr hist_nativeObj, IntPtr histSize_mat_nativeObj, IntPtr ranges_mat_nativeObj, bool accumulate);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_calcHist_11 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr mask_nativeObj, IntPtr hist_nativeObj, IntPtr histSize_mat_nativeObj, IntPtr ranges_mat_nativeObj);
	
				// C++:  void convertMaps(Mat map1, Mat map2, Mat& dstmap1, Mat& dstmap2, int dstmap1type, bool nninterpolation = false)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_convertMaps_10 (IntPtr map1_nativeObj, IntPtr map2_nativeObj, IntPtr dstmap1_nativeObj, IntPtr dstmap2_nativeObj, int dstmap1type, bool nninterpolation);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_convertMaps_11 (IntPtr map1_nativeObj, IntPtr map2_nativeObj, IntPtr dstmap1_nativeObj, IntPtr dstmap2_nativeObj, int dstmap1type);
	
				// C++:  Mat getRotationMatrix2D(Point2f center, double angle, double scale)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getRotationMatrix2D_10 (double center_x, double center_y, double angle, double scale);
	
				// C++:  void invertAffineTransform(Mat M, Mat& iM)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_invertAffineTransform_10 (IntPtr M_nativeObj, IntPtr iM_nativeObj);
	
				// C++:  Mat getPerspectiveTransform(Mat src, Mat dst)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getPerspectiveTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  Mat getAffineTransform(vector_Point2f src, vector_Point2f dst)
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_getAffineTransform_10 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj);
	
				// C++:  void getRectSubPix(Mat image, Size patchSize, Point2f center, Mat& patch, int patchType = -1)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_getRectSubPix_10 (IntPtr image_nativeObj, double patchSize_width, double patchSize_height, double center_x, double center_y, IntPtr patch_nativeObj, int patchType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_getRectSubPix_11 (IntPtr image_nativeObj, double patchSize_width, double patchSize_height, double center_x, double center_y, IntPtr patch_nativeObj);
	
				// C++:  void logPolar(Mat src, Mat& dst, Point2f center, double M, int flags)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_logPolar_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double center_x, double center_y, double M, int flags);
	
				// C++:  void linearPolar(Mat src, Mat& dst, Point2f center, double maxRadius, int flags)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_linearPolar_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double center_x, double center_y, double maxRadius, int flags);
	
				// C++:  void integral(Mat src, Mat& sum, int sdepth = -1)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, int sdepth);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj);
	
				// C++:  void integral(Mat src, Mat& sum, Mat& sqsum, int sdepth = -1, int sqdepth = -1)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral2_10 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj, int sdepth, int sqdepth);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_integral2_11 (IntPtr src_nativeObj, IntPtr sum_nativeObj, IntPtr sqsum_nativeObj);
	
				// C++:  void calcBackProject(vector_Mat images, vector_int channels, Mat hist, Mat& dst, vector_float ranges, double scale)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_calcBackProject_10 (IntPtr images_mat_nativeObj, IntPtr channels_mat_nativeObj, IntPtr hist_nativeObj, IntPtr dst_nativeObj, IntPtr ranges_mat_nativeObj, double scale);
	
				// C++:  double compareHist(Mat H1, Mat H2, int method)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_compareHist_10 (IntPtr H1_nativeObj, IntPtr H2_nativeObj, int method);
	
				// C++:  void equalizeHist(Mat src, Mat& dst)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_equalizeHist_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);
	
				// C++:  void watershed(Mat image, Mat& markers)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_watershed_10 (IntPtr image_nativeObj, IntPtr markers_nativeObj);
	
				// C++:  void pyrMeanShiftFiltering(Mat src, Mat& dst, double sp, double sr, int maxLevel = 1, TermCriteria termcrit = TermCriteria(TermCriteria::MAX_ITER+TermCriteria::EPS,5,1))
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrMeanShiftFiltering_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sp, double sr, int maxLevel, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_pyrMeanShiftFiltering_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sp, double sr);
	
				// C++:  void grabCut(Mat img, Mat& mask, Rect rect, Mat& bgdModel, Mat& fgdModel, int iterCount, int mode = GC_EVAL)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_grabCut_10 (IntPtr img_nativeObj, IntPtr mask_nativeObj, int rect_x, int rect_y, int rect_width, int rect_height, IntPtr bgdModel_nativeObj, IntPtr fgdModel_nativeObj, int iterCount, int mode);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_grabCut_11 (IntPtr img_nativeObj, IntPtr mask_nativeObj, int rect_x, int rect_y, int rect_width, int rect_height, IntPtr bgdModel_nativeObj, IntPtr fgdModel_nativeObj, int iterCount);
	
				// C++:  void distanceTransform(Mat src, Mat& dst, Mat& labels, int distanceType, int maskSize, int labelType = DIST_LABEL_CCOMP)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_distanceTransformWithLabels_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr labels_nativeObj, int distanceType, int maskSize, int labelType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_distanceTransformWithLabels_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr labels_nativeObj, int distanceType, int maskSize);
	
				// C++:  void distanceTransform(Mat src, Mat& dst, int distanceType, int maskSize, int dstType = CV_32F)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_distanceTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int distanceType, int maskSize, int dstType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_distanceTransform_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int distanceType, int maskSize);
	
				// C++:  int floodFill(Mat& image, Mat& mask, Point seedPoint, Scalar newVal, Rect* rect = 0, Scalar loDiff = Scalar(), Scalar upDiff = Scalar(), int flags = 4)
				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_floodFill_10 (IntPtr image_nativeObj, IntPtr mask_nativeObj, double seedPoint_x, double seedPoint_y, double newVal_val0, double newVal_val1, double newVal_val2, double newVal_val3, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] double[] rect_out, double loDiff_val0, double loDiff_val1, double loDiff_val2, double loDiff_val3, double upDiff_val0, double upDiff_val1, double upDiff_val2, double upDiff_val3, int flags);

				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_floodFill_11 (IntPtr image_nativeObj, IntPtr mask_nativeObj, double seedPoint_x, double seedPoint_y, double newVal_val0, double newVal_val1, double newVal_val2, double newVal_val3);
	
				// C++:  void cvtColor(Mat src, Mat& dst, int code, int dstCn = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cvtColor_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int code, int dstCn);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_cvtColor_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int code);
	
				// C++:  void demosaicing(Mat _src, Mat& _dst, int code, int dcn = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_demosaicing_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int code, int dcn);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_demosaicing_11 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, int code);
	
				// C++:  void matchTemplate(Mat image, Mat templ, Mat& result, int method, Mat mask = Mat())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_matchTemplate_10 (IntPtr image_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj, int method, IntPtr mask_nativeObj);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_matchTemplate_11 (IntPtr image_nativeObj, IntPtr templ_nativeObj, IntPtr result_nativeObj, int method);
	
				// C++:  int connectedComponents(Mat image, Mat& labels, int connectivity = 8, int ltype = CV_32S)
				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_connectedComponents_10 (IntPtr image_nativeObj, IntPtr labels_nativeObj, int connectivity, int ltype);

				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_connectedComponents_11 (IntPtr image_nativeObj, IntPtr labels_nativeObj);
	
				// C++:  int connectedComponentsWithStats(Mat image, Mat& labels, Mat& stats, Mat& centroids, int connectivity = 8, int ltype = CV_32S)
				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_connectedComponentsWithStats_10 (IntPtr image_nativeObj, IntPtr labels_nativeObj, IntPtr stats_nativeObj, IntPtr centroids_nativeObj, int connectivity, int ltype);

				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_connectedComponentsWithStats_11 (IntPtr image_nativeObj, IntPtr labels_nativeObj, IntPtr stats_nativeObj, IntPtr centroids_nativeObj);
	
				// C++:  void findContours(Mat& image, vector_vector_Point& contours, Mat& hierarchy, int mode, int method, Point offset = Point())
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_findContours_10 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, IntPtr hierarchy_nativeObj, int mode, int method, double offset_x, double offset_y);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_findContours_11 (IntPtr image_nativeObj, IntPtr contours_mat_nativeObj, IntPtr hierarchy_nativeObj, int mode, int method);
	
				// C++:  void approxPolyDP(vector_Point2f curve, vector_Point2f& approxCurve, double epsilon, bool closed)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_approxPolyDP_10 (IntPtr curve_mat_nativeObj, IntPtr approxCurve_mat_nativeObj, double epsilon, bool closed);
	
				// C++:  double arcLength(vector_Point2f curve, bool closed)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_arcLength_10 (IntPtr curve_mat_nativeObj, bool closed);
	
				// C++:  Rect boundingRect(vector_Point points)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_boundingRect_10 (IntPtr points_mat_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] double[] vals);
	
				// C++:  double contourArea(Mat contour, bool oriented = false)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_contourArea_10 (IntPtr contour_nativeObj, bool oriented);

				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_contourArea_11 (IntPtr contour_nativeObj);
	
				// C++:  RotatedRect minAreaRect(vector_Point2f points)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_minAreaRect_10 (IntPtr points_mat_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] double[] vals);
	
				// C++:  void boxPoints(RotatedRect box, Mat& points)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_boxPoints_10 (double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, IntPtr points_nativeObj);
	
				// C++:  void minEnclosingCircle(vector_Point2f points, Point2f& center, float& radius)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_minEnclosingCircle_10 (IntPtr points_mat_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] center_out, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] double[] radius_out);
	
				// C++:  double minEnclosingTriangle(Mat points, Mat& triangle)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_minEnclosingTriangle_10 (IntPtr points_nativeObj, IntPtr triangle_nativeObj);
	
				// C++:  double matchShapes(Mat contour1, Mat contour2, int method, double parameter)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_matchShapes_10 (IntPtr contour1_nativeObj, IntPtr contour2_nativeObj, int method, double parameter);
	
				// C++:  void convexHull(vector_Point points, vector_int& hull, bool clockwise = false,  _hidden_  returnPoints = true)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_convexHull_10 (IntPtr points_mat_nativeObj, IntPtr hull_mat_nativeObj, bool clockwise);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_convexHull_11 (IntPtr points_mat_nativeObj, IntPtr hull_mat_nativeObj);
	
				// C++:  void convexityDefects(vector_Point contour, vector_int convexhull, vector_Vec4i& convexityDefects)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_convexityDefects_10 (IntPtr contour_mat_nativeObj, IntPtr convexhull_mat_nativeObj, IntPtr convexityDefects_mat_nativeObj);
	
				// C++:  bool isContourConvex(vector_Point contour)
				[DllImport("opencvforunity")]
				private static extern bool imgproc_Imgproc_isContourConvex_10 (IntPtr contour_mat_nativeObj);
	
				// C++:  float intersectConvexConvex(Mat _p1, Mat _p2, Mat& _p12, bool handleNested = true)
				[DllImport("opencvforunity")]
				private static extern float imgproc_Imgproc_intersectConvexConvex_10 (IntPtr _p1_nativeObj, IntPtr _p2_nativeObj, IntPtr _p12_nativeObj, bool handleNested);

				[DllImport("opencvforunity")]
				private static extern float imgproc_Imgproc_intersectConvexConvex_11 (IntPtr _p1_nativeObj, IntPtr _p2_nativeObj, IntPtr _p12_nativeObj);
	
				// C++:  RotatedRect fitEllipse(vector_Point2f points)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fitEllipse_10 (IntPtr points_mat_nativeObj, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 5)] double[] vals);
	
				// C++:  void fitLine(Mat points, Mat& line, int distType, double param, double reps, double aeps)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_fitLine_10 (IntPtr points_nativeObj, IntPtr line_nativeObj, int distType, double param, double reps, double aeps);
	
				// C++:  double pointPolygonTest(vector_Point2f contour, Point2f pt, bool measureDist)
				[DllImport("opencvforunity")]
				private static extern double imgproc_Imgproc_pointPolygonTest_10 (IntPtr contour_mat_nativeObj, double pt_x, double pt_y, bool measureDist);
	
				// C++:  int rotatedRectangleIntersection(RotatedRect rect1, RotatedRect rect2, Mat& intersectingRegion)
				[DllImport("opencvforunity")]
				private static extern int imgproc_Imgproc_rotatedRectangleIntersection_10 (double rect1_center_x, double rect1_center_y, double rect1_size_width, double rect1_size_height, double rect1_angle, double rect2_center_x, double rect2_center_y, double rect2_size_width, double rect2_size_height, double rect2_angle, IntPtr intersectingRegion_nativeObj);
	
				// C++:  Ptr_CLAHE createCLAHE(double clipLimit = 40.0, Size tileGridSize = Size(8, 8))
				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_createCLAHE_10 (double clipLimit, double tileGridSize_width, double tileGridSize_height);

				[DllImport("opencvforunity")]
				private static extern IntPtr imgproc_Imgproc_createCLAHE_11 ();
	
				// C++:  void applyColorMap(Mat src, Mat& dst, int colormap)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_applyColorMap_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int colormap);
	
				// C++:  void line(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_line_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_line_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_line_12 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void arrowedLine(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int line_type = 8, int shift = 0, double tipLength = 0.1)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_arrowedLine_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int line_type, int shift, double tipLength);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_arrowedLine_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void rectangle(Mat& img, Point pt1, Point pt2, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_rectangle_10 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_rectangle_11 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_rectangle_12 (IntPtr img_nativeObj, double pt1_x, double pt1_y, double pt2_x, double pt2_y, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void circle(Mat& img, Point center, int radius, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_circle_10 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_circle_11 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_circle_12 (IntPtr img_nativeObj, double center_x, double center_y, int radius, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void ellipse(Mat& img, Point center, Size axes, double angle, double startAngle, double endAngle, Scalar color, int thickness = 1, int lineType = LINE_8, int shift = 0)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_10 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType, int shift);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_11 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_12 (IntPtr img_nativeObj, double center_x, double center_y, double axes_width, double axes_height, double angle, double startAngle, double endAngle, double color_val0, double color_val1, double color_val2, double color_val3);
	
				// C++:  void ellipse(Mat& img, RotatedRect box, Scalar color, int thickness = 1, int lineType = LINE_8)
				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_13 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness, int lineType);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_14 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3, int thickness);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_ellipse_15 (IntPtr img_nativeObj, double box_center_x, double box_center_y, double box_size_width, double box_size_height, double box_angle, double color_val0, double color_val1, double color_val2, double color_val3);

				[DllImport("opencvforunity")]
				private static extern void imgproc_Imgproc_n_1getTextSize (string text, int fontFace, double fontScale, int thickness, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] int[] baseLine, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] double[] vals);
#endif
		}
}