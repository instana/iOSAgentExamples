using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace Gzip
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern _RuneLocale _DefaultRuneLocale;
		[Field ("_DefaultRuneLocale", "__Internal")]
		_RuneLocale _DefaultRuneLocale { get; }

		// extern _RuneLocale * _CurrentRuneLocale;
		[Field ("_CurrentRuneLocale", "__Internal")]
		unsafe _RuneLocale* _CurrentRuneLocale { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int signgam;
		[Field ("signgam", "__Internal")]
		int signgam { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const char *const [32] sys_signame;
		[Field ("sys_signame", "__Internal")]
		unsafe sbyte*[] sys_signame { get; }

		// extern const char *const [32] sys_siglist;
		[Field ("sys_siglist", "__Internal")]
		unsafe sbyte*[] sys_siglist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern FILE * __stdinp;
		[Field ("__stdinp", "__Internal")]
		unsafe FILE* __stdinp { get; }

		// extern FILE * __stdoutp;
		[Field ("__stdoutp", "__Internal")]
		unsafe FILE* __stdoutp { get; }

		// extern FILE * __stderrp;
		[Field ("__stderrp", "__Internal")]
		unsafe FILE* __stderrp { get; }

		// extern const int sys_nerr;
		[Field ("sys_nerr", "__Internal")]
		int sys_nerr { get; }

		// extern const char *const [] sys_errlist;
		[Field ("sys_errlist", "__Internal")]
		unsafe sbyte*[] sys_errlist { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int __mb_cur_max;
		[Field ("__mb_cur_max", "__Internal")]
		int __mb_cur_max { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char *[] tzname;
		[Field ("tzname", "__Internal")]
		unsafe sbyte*[] tzname { get; }

		// extern int getdate_err;
		[Field ("getdate_err", "__Internal")]
		int getdate_err { get; }

		// extern long timezone asm("_timezone");
		[Field ("timezone", "__Internal")]
		nint timezone { get; }

		// extern int daylight;
		[Field ("daylight", "__Internal")]
		int daylight { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern void *[32] _NSConcreteGlobalBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteGlobalBlock", "__Internal")]
		unsafe void*[] _NSConcreteGlobalBlock { get; }

		// extern void *[32] _NSConcreteStackBlock __attribute__((availability(ios, introduced=3.2)));
		[iOS (3, 2)]
		[Field ("_NSConcreteStackBlock", "__Internal")]
		unsafe void*[] _NSConcreteStackBlock { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double kCFCoreFoundationVersionNumber;
		[Field ("kCFCoreFoundationVersionNumber", "__Internal")]
		double kCFCoreFoundationVersionNumber { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNullRef kCFNull;
		[Field ("kCFNull", "__Internal")]
		unsafe CFNullRef* kCFNull { get; }

		// extern const CFAllocatorRef kCFAllocatorDefault;
		[Field ("kCFAllocatorDefault", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorDefault { get; }

		// extern const CFAllocatorRef kCFAllocatorSystemDefault;
		[Field ("kCFAllocatorSystemDefault", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorSystemDefault { get; }

		// extern const CFAllocatorRef kCFAllocatorMalloc;
		[Field ("kCFAllocatorMalloc", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorMalloc { get; }

		// extern const CFAllocatorRef kCFAllocatorMallocZone;
		[Field ("kCFAllocatorMallocZone", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorMallocZone { get; }

		// extern const CFAllocatorRef kCFAllocatorNull;
		[Field ("kCFAllocatorNull", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorNull { get; }

		// extern const CFAllocatorRef kCFAllocatorUseContext;
		[Field ("kCFAllocatorUseContext", "__Internal")]
		unsafe CFAllocatorRef* kCFAllocatorUseContext { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFArrayCallBacks kCFTypeArrayCallBacks;
		[Field ("kCFTypeArrayCallBacks", "__Internal")]
		CFArrayCallBacks kCFTypeArrayCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFBagCallBacks kCFTypeBagCallBacks;
		[Field ("kCFTypeBagCallBacks", "__Internal")]
		CFBagCallBacks kCFTypeBagCallBacks { get; }

		// extern const CFBagCallBacks kCFCopyStringBagCallBacks;
		[Field ("kCFCopyStringBagCallBacks", "__Internal")]
		CFBagCallBacks kCFCopyStringBagCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFBinaryHeapCallBacks kCFStringBinaryHeapCallBacks;
		[Field ("kCFStringBinaryHeapCallBacks", "__Internal")]
		CFBinaryHeapCallBacks kCFStringBinaryHeapCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDictionaryKeyCallBacks kCFTypeDictionaryKeyCallBacks;
		[Field ("kCFTypeDictionaryKeyCallBacks", "__Internal")]
		CFDictionaryKeyCallBacks kCFTypeDictionaryKeyCallBacks { get; }

		// extern const CFDictionaryKeyCallBacks kCFCopyStringDictionaryKeyCallBacks;
		[Field ("kCFCopyStringDictionaryKeyCallBacks", "__Internal")]
		CFDictionaryKeyCallBacks kCFCopyStringDictionaryKeyCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDictionaryValueCallBacks kCFTypeDictionaryValueCallBacks;
		[Field ("kCFTypeDictionaryValueCallBacks", "__Internal")]
		CFDictionaryValueCallBacks kCFTypeDictionaryValueCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNotificationName kCFLocaleCurrentLocaleDidChangeNotification __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFLocaleCurrentLocaleDidChangeNotification", "__Internal")]
		unsafe CFNotificationName* kCFLocaleCurrentLocaleDidChangeNotification { get; }

		// extern const CFLocaleKey kCFLocaleIdentifier;
		[Field ("kCFLocaleIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleLanguageCode;
		[Field ("kCFLocaleLanguageCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleLanguageCode { get; }

		// extern const CFLocaleKey kCFLocaleCountryCode;
		[Field ("kCFLocaleCountryCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCountryCode { get; }

		// extern const CFLocaleKey kCFLocaleScriptCode;
		[Field ("kCFLocaleScriptCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleScriptCode { get; }

		// extern const CFLocaleKey kCFLocaleVariantCode;
		[Field ("kCFLocaleVariantCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleVariantCode { get; }

		// extern const CFLocaleKey kCFLocaleExemplarCharacterSet;
		[Field ("kCFLocaleExemplarCharacterSet", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleExemplarCharacterSet { get; }

		// extern const CFLocaleKey kCFLocaleCalendarIdentifier;
		[Field ("kCFLocaleCalendarIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCalendarIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleCalendar;
		[Field ("kCFLocaleCalendar", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCalendar { get; }

		// extern const CFLocaleKey kCFLocaleCollationIdentifier;
		[Field ("kCFLocaleCollationIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCollationIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleUsesMetricSystem;
		[Field ("kCFLocaleUsesMetricSystem", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleUsesMetricSystem { get; }

		// extern const CFLocaleKey kCFLocaleMeasurementSystem;
		[Field ("kCFLocaleMeasurementSystem", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleMeasurementSystem { get; }

		// extern const CFLocaleKey kCFLocaleDecimalSeparator;
		[Field ("kCFLocaleDecimalSeparator", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleDecimalSeparator { get; }

		// extern const CFLocaleKey kCFLocaleGroupingSeparator;
		[Field ("kCFLocaleGroupingSeparator", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleGroupingSeparator { get; }

		// extern const CFLocaleKey kCFLocaleCurrencySymbol;
		[Field ("kCFLocaleCurrencySymbol", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCurrencySymbol { get; }

		// extern const CFLocaleKey kCFLocaleCurrencyCode;
		[Field ("kCFLocaleCurrencyCode", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCurrencyCode { get; }

		// extern const CFLocaleKey kCFLocaleCollatorIdentifier __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleCollatorIdentifier", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleCollatorIdentifier { get; }

		// extern const CFLocaleKey kCFLocaleQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleQuotationBeginDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleQuotationBeginDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleQuotationEndDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleQuotationEndDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleAlternateQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleAlternateQuotationBeginDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleAlternateQuotationBeginDelimiterKey { get; }

		// extern const CFLocaleKey kCFLocaleAlternateQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFLocaleAlternateQuotationEndDelimiterKey", "__Internal")]
		unsafe CFLocaleKey* kCFLocaleAlternateQuotationEndDelimiterKey { get; }

		// extern const CFCalendarIdentifier kCFGregorianCalendar;
		[Field ("kCFGregorianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFGregorianCalendar { get; }

		// extern const CFCalendarIdentifier kCFBuddhistCalendar;
		[Field ("kCFBuddhistCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFBuddhistCalendar { get; }

		// extern const CFCalendarIdentifier kCFChineseCalendar;
		[Field ("kCFChineseCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFChineseCalendar { get; }

		// extern const CFCalendarIdentifier kCFHebrewCalendar;
		[Field ("kCFHebrewCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFHebrewCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicCalendar;
		[Field ("kCFIslamicCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicCivilCalendar;
		[Field ("kCFIslamicCivilCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicCivilCalendar { get; }

		// extern const CFCalendarIdentifier kCFJapaneseCalendar;
		[Field ("kCFJapaneseCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFJapaneseCalendar { get; }

		// extern const CFCalendarIdentifier kCFRepublicOfChinaCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFRepublicOfChinaCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFRepublicOfChinaCalendar { get; }

		// extern const CFCalendarIdentifier kCFPersianCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFPersianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFPersianCalendar { get; }

		// extern const CFCalendarIdentifier kCFIndianCalendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFIndianCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIndianCalendar { get; }

		// extern const CFCalendarIdentifier kCFISO8601Calendar __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFISO8601Calendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFISO8601Calendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicTabularCalendar __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFIslamicTabularCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicTabularCalendar { get; }

		// extern const CFCalendarIdentifier kCFIslamicUmmAlQuraCalendar __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFIslamicUmmAlQuraCalendar", "__Internal")]
		unsafe CFCalendarIdentifier* kCFIslamicUmmAlQuraCalendar { get; }

		// extern const CFTimeInterval kCFAbsoluteTimeIntervalSince1970;
		[Field ("kCFAbsoluteTimeIntervalSince1970", "__Internal")]
		double kCFAbsoluteTimeIntervalSince1970 { get; }

		// extern const CFTimeInterval kCFAbsoluteTimeIntervalSince1904;
		[Field ("kCFAbsoluteTimeIntervalSince1904", "__Internal")]
		double kCFAbsoluteTimeIntervalSince1904 { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFStringTransformStripCombiningMarks;
		[Field ("kCFStringTransformStripCombiningMarks", "__Internal")]
		unsafe CFStringRef* kCFStringTransformStripCombiningMarks { get; }

		// extern const CFStringRef kCFStringTransformToLatin;
		[Field ("kCFStringTransformToLatin", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToLatin { get; }

		// extern const CFStringRef kCFStringTransformFullwidthHalfwidth;
		[Field ("kCFStringTransformFullwidthHalfwidth", "__Internal")]
		unsafe CFStringRef* kCFStringTransformFullwidthHalfwidth { get; }

		// extern const CFStringRef kCFStringTransformLatinKatakana;
		[Field ("kCFStringTransformLatinKatakana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinKatakana { get; }

		// extern const CFStringRef kCFStringTransformLatinHiragana;
		[Field ("kCFStringTransformLatinHiragana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHiragana { get; }

		// extern const CFStringRef kCFStringTransformHiraganaKatakana;
		[Field ("kCFStringTransformHiraganaKatakana", "__Internal")]
		unsafe CFStringRef* kCFStringTransformHiraganaKatakana { get; }

		// extern const CFStringRef kCFStringTransformMandarinLatin;
		[Field ("kCFStringTransformMandarinLatin", "__Internal")]
		unsafe CFStringRef* kCFStringTransformMandarinLatin { get; }

		// extern const CFStringRef kCFStringTransformLatinHangul;
		[Field ("kCFStringTransformLatinHangul", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHangul { get; }

		// extern const CFStringRef kCFStringTransformLatinArabic;
		[Field ("kCFStringTransformLatinArabic", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinArabic { get; }

		// extern const CFStringRef kCFStringTransformLatinHebrew;
		[Field ("kCFStringTransformLatinHebrew", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinHebrew { get; }

		// extern const CFStringRef kCFStringTransformLatinThai;
		[Field ("kCFStringTransformLatinThai", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinThai { get; }

		// extern const CFStringRef kCFStringTransformLatinCyrillic;
		[Field ("kCFStringTransformLatinCyrillic", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinCyrillic { get; }

		// extern const CFStringRef kCFStringTransformLatinGreek;
		[Field ("kCFStringTransformLatinGreek", "__Internal")]
		unsafe CFStringRef* kCFStringTransformLatinGreek { get; }

		// extern const CFStringRef kCFStringTransformToXMLHex;
		[Field ("kCFStringTransformToXMLHex", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToXMLHex { get; }

		// extern const CFStringRef kCFStringTransformToUnicodeName;
		[Field ("kCFStringTransformToUnicodeName", "__Internal")]
		unsafe CFStringRef* kCFStringTransformToUnicodeName { get; }

		// extern const CFStringRef kCFStringTransformStripDiacritics __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFStringTransformStripDiacritics", "__Internal")]
		unsafe CFStringRef* kCFStringTransformStripDiacritics { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNotificationName kCFTimeZoneSystemTimeZoneDidChangeNotification __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFTimeZoneSystemTimeZoneDidChangeNotification", "__Internal")]
		unsafe CFNotificationName* kCFTimeZoneSystemTimeZoneDidChangeNotification { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFDateFormatterKey kCFDateFormatterIsLenient;
		[Field ("kCFDateFormatterIsLenient", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterIsLenient { get; }

		// extern const CFDateFormatterKey kCFDateFormatterTimeZone;
		[Field ("kCFDateFormatterTimeZone", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterTimeZone { get; }

		// extern const CFDateFormatterKey kCFDateFormatterCalendarName;
		[Field ("kCFDateFormatterCalendarName", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterCalendarName { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDefaultFormat;
		[Field ("kCFDateFormatterDefaultFormat", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDefaultFormat { get; }

		// extern const CFDateFormatterKey kCFDateFormatterTwoDigitStartDate;
		[Field ("kCFDateFormatterTwoDigitStartDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterTwoDigitStartDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDefaultDate;
		[Field ("kCFDateFormatterDefaultDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDefaultDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterCalendar;
		[Field ("kCFDateFormatterCalendar", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterCalendar { get; }

		// extern const CFDateFormatterKey kCFDateFormatterEraSymbols;
		[Field ("kCFDateFormatterEraSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterEraSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterMonthSymbols;
		[Field ("kCFDateFormatterMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortMonthSymbols;
		[Field ("kCFDateFormatterShortMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterWeekdaySymbols;
		[Field ("kCFDateFormatterWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortWeekdaySymbols;
		[Field ("kCFDateFormatterShortWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterAMSymbol;
		[Field ("kCFDateFormatterAMSymbol", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterAMSymbol { get; }

		// extern const CFDateFormatterKey kCFDateFormatterPMSymbol;
		[Field ("kCFDateFormatterPMSymbol", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterPMSymbol { get; }

		// extern const CFDateFormatterKey kCFDateFormatterLongEraSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterLongEraSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterLongEraSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortStandaloneMonthSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortStandaloneMonthSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortStandaloneMonthSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterVeryShortStandaloneWeekdaySymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterVeryShortStandaloneWeekdaySymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterVeryShortStandaloneWeekdaySymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterStandaloneQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterStandaloneQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterStandaloneQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterShortStandaloneQuarterSymbols __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterShortStandaloneQuarterSymbols", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterShortStandaloneQuarterSymbols { get; }

		// extern const CFDateFormatterKey kCFDateFormatterGregorianStartDate __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFDateFormatterGregorianStartDate", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterGregorianStartDate { get; }

		// extern const CFDateFormatterKey kCFDateFormatterDoesRelativeDateFormattingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFDateFormatterDoesRelativeDateFormattingKey", "__Internal")]
		unsafe CFDateFormatterKey* kCFDateFormatterDoesRelativeDateFormattingKey { get; }

		// extern const CFErrorDomain kCFErrorDomainPOSIX __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainPOSIX", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainPOSIX { get; }

		// extern const CFErrorDomain kCFErrorDomainOSStatus __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainOSStatus", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainOSStatus { get; }

		// extern const CFErrorDomain kCFErrorDomainMach __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainMach", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainMach { get; }

		// extern const CFErrorDomain kCFErrorDomainCocoa __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDomainCocoa", "__Internal")]
		unsafe CFErrorDomain* kCFErrorDomainCocoa { get; }

		// extern const CFStringRef kCFErrorLocalizedDescriptionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedDescriptionKey { get; }

		// extern const CFStringRef kCFErrorLocalizedFailureKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFErrorLocalizedFailureKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedFailureKey { get; }

		// extern const CFStringRef kCFErrorLocalizedFailureReasonKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedFailureReasonKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedFailureReasonKey { get; }

		// extern const CFStringRef kCFErrorLocalizedRecoverySuggestionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorLocalizedRecoverySuggestionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorLocalizedRecoverySuggestionKey { get; }

		// extern const CFStringRef kCFErrorDescriptionKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFErrorDescriptionKey { get; }

		// extern const CFStringRef kCFErrorUnderlyingErrorKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFErrorUnderlyingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFErrorUnderlyingErrorKey { get; }

		// extern const CFStringRef kCFErrorURLKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFErrorURLKey", "__Internal")]
		unsafe CFStringRef* kCFErrorURLKey { get; }

		// extern const CFStringRef kCFErrorFilePathKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFErrorFilePathKey", "__Internal")]
		unsafe CFStringRef* kCFErrorFilePathKey { get; }

		// extern const CFBooleanRef kCFBooleanTrue;
		[Field ("kCFBooleanTrue", "__Internal")]
		unsafe CFBooleanRef* kCFBooleanTrue { get; }

		// extern const CFBooleanRef kCFBooleanFalse;
		[Field ("kCFBooleanFalse", "__Internal")]
		unsafe CFBooleanRef* kCFBooleanFalse { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNumberRef kCFNumberPositiveInfinity;
		[Field ("kCFNumberPositiveInfinity", "__Internal")]
		unsafe CFNumberRef* kCFNumberPositiveInfinity { get; }

		// extern const CFNumberRef kCFNumberNegativeInfinity;
		[Field ("kCFNumberNegativeInfinity", "__Internal")]
		unsafe CFNumberRef* kCFNumberNegativeInfinity { get; }

		// extern const CFNumberRef kCFNumberNaN;
		[Field ("kCFNumberNaN", "__Internal")]
		unsafe CFNumberRef* kCFNumberNaN { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyCode;
		[Field ("kCFNumberFormatterCurrencyCode", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyCode { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterDecimalSeparator;
		[Field ("kCFNumberFormatterDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyDecimalSeparator;
		[Field ("kCFNumberFormatterCurrencyDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterAlwaysShowDecimalSeparator;
		[Field ("kCFNumberFormatterAlwaysShowDecimalSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterAlwaysShowDecimalSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterGroupingSeparator;
		[Field ("kCFNumberFormatterGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterUseGroupingSeparator;
		[Field ("kCFNumberFormatterUseGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterUseGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPercentSymbol;
		[Field ("kCFNumberFormatterPercentSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPercentSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterZeroSymbol;
		[Field ("kCFNumberFormatterZeroSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterZeroSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNaNSymbol;
		[Field ("kCFNumberFormatterNaNSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNaNSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterInfinitySymbol;
		[Field ("kCFNumberFormatterInfinitySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterInfinitySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinusSign;
		[Field ("kCFNumberFormatterMinusSign", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinusSign { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPlusSign;
		[Field ("kCFNumberFormatterPlusSign", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPlusSign { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencySymbol;
		[Field ("kCFNumberFormatterCurrencySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterExponentSymbol;
		[Field ("kCFNumberFormatterExponentSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterExponentSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinIntegerDigits;
		[Field ("kCFNumberFormatterMinIntegerDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinIntegerDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxIntegerDigits;
		[Field ("kCFNumberFormatterMaxIntegerDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxIntegerDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinFractionDigits;
		[Field ("kCFNumberFormatterMinFractionDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinFractionDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxFractionDigits;
		[Field ("kCFNumberFormatterMaxFractionDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxFractionDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterGroupingSize;
		[Field ("kCFNumberFormatterGroupingSize", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterGroupingSize { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterSecondaryGroupingSize;
		[Field ("kCFNumberFormatterSecondaryGroupingSize", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterSecondaryGroupingSize { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterRoundingMode;
		[Field ("kCFNumberFormatterRoundingMode", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterRoundingMode { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterRoundingIncrement;
		[Field ("kCFNumberFormatterRoundingIncrement", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterRoundingIncrement { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterFormatWidth;
		[Field ("kCFNumberFormatterFormatWidth", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterFormatWidth { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPaddingPosition;
		[Field ("kCFNumberFormatterPaddingPosition", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPaddingPosition { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPaddingCharacter;
		[Field ("kCFNumberFormatterPaddingCharacter", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPaddingCharacter { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterDefaultFormat;
		[Field ("kCFNumberFormatterDefaultFormat", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterDefaultFormat { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMultiplier;
		[Field ("kCFNumberFormatterMultiplier", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMultiplier { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPositivePrefix;
		[Field ("kCFNumberFormatterPositivePrefix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPositivePrefix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPositiveSuffix;
		[Field ("kCFNumberFormatterPositiveSuffix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPositiveSuffix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNegativePrefix;
		[Field ("kCFNumberFormatterNegativePrefix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNegativePrefix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterNegativeSuffix;
		[Field ("kCFNumberFormatterNegativeSuffix", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterNegativeSuffix { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterPerMillSymbol;
		[Field ("kCFNumberFormatterPerMillSymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterPerMillSymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterInternationalCurrencySymbol;
		[Field ("kCFNumberFormatterInternationalCurrencySymbol", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterInternationalCurrencySymbol { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterCurrencyGroupingSeparator __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterCurrencyGroupingSeparator", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterCurrencyGroupingSeparator { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterIsLenient __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterIsLenient", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterIsLenient { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterUseSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterUseSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterUseSignificantDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMinSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterMinSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMinSignificantDigits { get; }

		// extern const CFNumberFormatterKey kCFNumberFormatterMaxSignificantDigits __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("kCFNumberFormatterMaxSignificantDigits", "__Internal")]
		unsafe CFNumberFormatterKey* kCFNumberFormatterMaxSignificantDigits { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFPreferencesAnyApplication;
		[Field ("kCFPreferencesAnyApplication", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyApplication { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentApplication;
		[Field ("kCFPreferencesCurrentApplication", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentApplication { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesAnyHost;
		[Field ("kCFPreferencesAnyHost", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyHost { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentHost;
		[Field ("kCFPreferencesCurrentHost", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentHost { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesAnyUser;
		[Field ("kCFPreferencesAnyUser", "__Internal")]
		unsafe CFStringRef* kCFPreferencesAnyUser { get; }

		// extern const CFStringRef _Nonnull kCFPreferencesCurrentUser;
		[Field ("kCFPreferencesCurrentUser", "__Internal")]
		unsafe CFStringRef* kCFPreferencesCurrentUser { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFURLKeysOfUnsetValuesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLKeysOfUnsetValuesKey", "__Internal")]
		unsafe CFStringRef* kCFURLKeysOfUnsetValuesKey { get; }

		// extern const CFStringRef kCFURLNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLNameKey { get; }

		// extern const CFStringRef kCFURLLocalizedNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedNameKey { get; }

		// extern const CFStringRef kCFURLIsRegularFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsRegularFileKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsRegularFileKey { get; }

		// extern const CFStringRef kCFURLIsDirectoryKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsDirectoryKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsDirectoryKey { get; }

		// extern const CFStringRef kCFURLIsSymbolicLinkKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsSymbolicLinkKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsSymbolicLinkKey { get; }

		// extern const CFStringRef kCFURLIsVolumeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsVolumeKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsVolumeKey { get; }

		// extern const CFStringRef kCFURLIsPackageKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsPackageKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsPackageKey { get; }

		// extern const CFStringRef kCFURLIsApplicationKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("kCFURLIsApplicationKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsApplicationKey { get; }

		// extern const CFStringRef kCFURLApplicationIsScriptableKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 11)]
		[Field ("kCFURLApplicationIsScriptableKey", "__Internal")]
		unsafe CFStringRef* kCFURLApplicationIsScriptableKey { get; }

		// extern const CFStringRef kCFURLIsSystemImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsSystemImmutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsSystemImmutableKey { get; }

		// extern const CFStringRef kCFURLIsUserImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsUserImmutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsUserImmutableKey { get; }

		// extern const CFStringRef kCFURLIsHiddenKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsHiddenKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsHiddenKey { get; }

		// extern const CFStringRef kCFURLHasHiddenExtensionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLHasHiddenExtensionKey", "__Internal")]
		unsafe CFStringRef* kCFURLHasHiddenExtensionKey { get; }

		// extern const CFStringRef kCFURLCreationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLCreationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLCreationDateKey { get; }

		// extern const CFStringRef kCFURLContentAccessDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLContentAccessDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLContentAccessDateKey { get; }

		// extern const CFStringRef kCFURLContentModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLContentModificationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLContentModificationDateKey { get; }

		// extern const CFStringRef kCFURLAttributeModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLAttributeModificationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLAttributeModificationDateKey { get; }

		// extern const CFStringRef kCFURLLinkCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLinkCountKey", "__Internal")]
		unsafe CFStringRef* kCFURLLinkCountKey { get; }

		// extern const CFStringRef kCFURLParentDirectoryURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLParentDirectoryURLKey", "__Internal")]
		unsafe CFStringRef* kCFURLParentDirectoryURLKey { get; }

		// extern const CFStringRef kCFURLVolumeURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeURLKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeURLKey { get; }

		// extern const CFStringRef kCFURLTypeIdentifierKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLTypeIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLTypeIdentifierKey { get; }

		// extern const CFStringRef kCFURLLocalizedTypeDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedTypeDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedTypeDescriptionKey { get; }

		// extern const CFStringRef kCFURLLabelNumberKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLabelNumberKey", "__Internal")]
		unsafe CFStringRef* kCFURLLabelNumberKey { get; }

		// extern const CFStringRef kCFURLLabelColorKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLLabelColorKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLLabelColorKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLLabelColorKey")]
		[Field ("kCFURLLabelColorKey", "__Internal")]
		unsafe CFStringRef* kCFURLLabelColorKey { get; }

		// extern const CFStringRef kCFURLLocalizedLabelKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLLocalizedLabelKey", "__Internal")]
		unsafe CFStringRef* kCFURLLocalizedLabelKey { get; }

		// extern const CFStringRef kCFURLEffectiveIconKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLEffectiveIconKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLEffectiveIconKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLEffectiveIconKey")]
		[Field ("kCFURLEffectiveIconKey", "__Internal")]
		unsafe CFStringRef* kCFURLEffectiveIconKey { get; }

		// extern const CFStringRef kCFURLCustomIconKey __attribute__((availability(macos, introduced=10.6, deprecated=10.12))) __attribute__((availability(ios, introduced=4.0, deprecated=10.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=3.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=10.0)));
		[Introduced (PlatformName.MacOSX, 10, 6, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.MacOSX, 10, 12, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.iOS, 10, 0, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.WatchOS, 3, 0, message: "Use NSURLCustomIconKey")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLCustomIconKey")]
		[Deprecated (PlatformName.TvOS, 10, 0, message: "Use NSURLCustomIconKey")]
		[Field ("kCFURLCustomIconKey", "__Internal")]
		unsafe CFStringRef* kCFURLCustomIconKey { get; }

		// extern const CFStringRef kCFURLFileResourceIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceIdentifierKey { get; }

		// extern const CFStringRef kCFURLVolumeIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIdentifierKey { get; }

		// extern const CFStringRef kCFURLPreferredIOBlockSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLPreferredIOBlockSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLPreferredIOBlockSizeKey { get; }

		// extern const CFStringRef kCFURLIsReadableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsReadableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsReadableKey { get; }

		// extern const CFStringRef kCFURLIsWritableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsWritableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsWritableKey { get; }

		// extern const CFStringRef kCFURLIsExecutableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsExecutableKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsExecutableKey { get; }

		// extern const CFStringRef kCFURLFileSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileSecurityKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileSecurityKey { get; }

		// extern const CFStringRef kCFURLIsExcludedFromBackupKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=5.1))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (5, 1)]
		[Field ("kCFURLIsExcludedFromBackupKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsExcludedFromBackupKey { get; }

		// extern const CFStringRef kCFURLTagNamesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("kCFURLTagNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLTagNamesKey { get; }

		// extern const CFStringRef kCFURLPathKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (6, 0)]
		[Field ("kCFURLPathKey", "__Internal")]
		unsafe CFStringRef* kCFURLPathKey { get; }

		// extern const CFStringRef kCFURLCanonicalPathKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLCanonicalPathKey", "__Internal")]
		unsafe CFStringRef* kCFURLCanonicalPathKey { get; }

		// extern const CFStringRef kCFURLIsMountTriggerKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("kCFURLIsMountTriggerKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsMountTriggerKey { get; }

		// extern const CFStringRef kCFURLGenerationIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLGenerationIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLGenerationIdentifierKey { get; }

		// extern const CFStringRef kCFURLDocumentIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLDocumentIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFURLDocumentIdentifierKey { get; }

		// extern const CFStringRef kCFURLAddedToDirectoryDateKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("kCFURLAddedToDirectoryDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLAddedToDirectoryDateKey { get; }

		// extern const CFStringRef kCFURLQuarantinePropertiesKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 10)]
		[Field ("kCFURLQuarantinePropertiesKey", "__Internal")]
		unsafe CFStringRef* kCFURLQuarantinePropertiesKey { get; }

		// extern const CFStringRef kCFURLFileResourceTypeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeKey { get; }

		// extern const CFStringRef kCFURLFileResourceTypeNamedPipe __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeNamedPipe", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeNamedPipe { get; }

		// extern const CFStringRef kCFURLFileResourceTypeCharacterSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeCharacterSpecial", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeCharacterSpecial { get; }

		// extern const CFStringRef kCFURLFileResourceTypeDirectory __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeDirectory", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeDirectory { get; }

		// extern const CFStringRef kCFURLFileResourceTypeBlockSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeBlockSpecial", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeBlockSpecial { get; }

		// extern const CFStringRef kCFURLFileResourceTypeRegular __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeRegular", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeRegular { get; }

		// extern const CFStringRef kCFURLFileResourceTypeSymbolicLink __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeSymbolicLink", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeSymbolicLink { get; }

		// extern const CFStringRef kCFURLFileResourceTypeSocket __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeSocket", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeSocket { get; }

		// extern const CFStringRef kCFURLFileResourceTypeUnknown __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLFileResourceTypeUnknown", "__Internal")]
		unsafe CFStringRef* kCFURLFileResourceTypeUnknown { get; }

		// extern const CFStringRef kCFURLFileSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileSizeKey { get; }

		// extern const CFStringRef kCFURLFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLFileAllocatedSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileAllocatedSizeKey { get; }

		// extern const CFStringRef kCFURLTotalFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLTotalFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLTotalFileSizeKey { get; }

		// extern const CFStringRef kCFURLTotalFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLTotalFileAllocatedSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLTotalFileAllocatedSizeKey { get; }

		// extern const CFStringRef kCFURLIsAliasFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLIsAliasFileKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsAliasFileKey { get; }

		// extern const CFStringRef kCFURLFileProtectionKey __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionKey", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionKey { get; }

		// extern const CFStringRef kCFURLFileProtectionNone __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionNone", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionNone { get; }

		// extern const CFStringRef kCFURLFileProtectionComplete __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionComplete", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionComplete { get; }

		// extern const CFStringRef kCFURLFileProtectionCompleteUnlessOpen __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionCompleteUnlessOpen", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionCompleteUnlessOpen { get; }

		// extern const CFStringRef kCFURLFileProtectionCompleteUntilFirstUserAuthentication __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("kCFURLFileProtectionCompleteUntilFirstUserAuthentication", "__Internal")]
		unsafe CFStringRef* kCFURLFileProtectionCompleteUntilFirstUserAuthentication { get; }

		// extern const CFStringRef kCFURLVolumeLocalizedFormatDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeLocalizedFormatDescriptionKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeLocalizedFormatDescriptionKey { get; }

		// extern const CFStringRef kCFURLVolumeTotalCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeTotalCapacityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeTotalCapacityKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeAvailableCapacityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityForImportantUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeAvailableCapacityForImportantUsageKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityForImportantUsageKey { get; }

		// extern const CFStringRef kCFURLVolumeAvailableCapacityForOpportunisticUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeAvailableCapacityForOpportunisticUsageKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeAvailableCapacityForOpportunisticUsageKey { get; }

		// extern const CFStringRef kCFURLVolumeResourceCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeResourceCountKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeResourceCountKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsPersistentIDsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsPersistentIDsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsPersistentIDsKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSymbolicLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsSymbolicLinksKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSymbolicLinksKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsHardLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsHardLinksKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsHardLinksKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsJournalingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsJournalingKey { get; }

		// extern const CFStringRef kCFURLVolumeIsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeIsJournalingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsJournalingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSparseFilesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsSparseFilesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSparseFilesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsZeroRunsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsZeroRunsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsZeroRunsKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCaseSensitiveNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsCaseSensitiveNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCaseSensitiveNamesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCasePreservedNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("kCFURLVolumeSupportsCasePreservedNamesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCasePreservedNamesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsRootDirectoryDatesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsRootDirectoryDatesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsRootDirectoryDatesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsVolumeSizesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsVolumeSizesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsVolumeSizesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsRenamingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsAdvisoryFileLockingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsAdvisoryFileLockingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsAdvisoryFileLockingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsExtendedSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeSupportsExtendedSecurityKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsExtendedSecurityKey { get; }

		// extern const CFStringRef kCFURLVolumeIsBrowsableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsBrowsableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsBrowsableKey { get; }

		// extern const CFStringRef kCFURLVolumeMaximumFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeMaximumFileSizeKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeMaximumFileSizeKey { get; }

		// extern const CFStringRef kCFURLVolumeIsEjectableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsEjectableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsEjectableKey { get; }

		// extern const CFStringRef kCFURLVolumeIsRemovableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsRemovableKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsRemovableKey { get; }

		// extern const CFStringRef kCFURLVolumeIsInternalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsInternalKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsInternalKey { get; }

		// extern const CFStringRef kCFURLVolumeIsAutomountedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsAutomountedKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsAutomountedKey { get; }

		// extern const CFStringRef kCFURLVolumeIsLocalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsLocalKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsLocalKey { get; }

		// extern const CFStringRef kCFURLVolumeIsReadOnlyKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeIsReadOnlyKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsReadOnlyKey { get; }

		// extern const CFStringRef kCFURLVolumeCreationDateKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeCreationDateKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeCreationDateKey { get; }

		// extern const CFStringRef kCFURLVolumeURLForRemountingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeURLForRemountingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeURLForRemountingKey { get; }

		// extern const CFStringRef kCFURLVolumeUUIDStringKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeUUIDStringKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeUUIDStringKey { get; }

		// extern const CFStringRef kCFURLVolumeNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeNameKey { get; }

		// extern const CFStringRef kCFURLVolumeLocalizedNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLVolumeLocalizedNameKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeLocalizedNameKey { get; }

		// extern const CFStringRef kCFURLVolumeIsEncryptedKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeIsEncryptedKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsEncryptedKey { get; }

		// extern const CFStringRef kCFURLVolumeIsRootFileSystemKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeIsRootFileSystemKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeIsRootFileSystemKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsCompressionKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsCompressionKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsCompressionKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsFileCloningKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsFileCloningKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsFileCloningKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsSwapRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsSwapRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsSwapRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsExclusiveRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kCFURLVolumeSupportsExclusiveRenamingKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsExclusiveRenamingKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsImmutableFilesKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeSupportsImmutableFilesKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsImmutableFilesKey { get; }

		// extern const CFStringRef kCFURLVolumeSupportsAccessPermissionsKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kCFURLVolumeSupportsAccessPermissionsKey", "__Internal")]
		unsafe CFStringRef* kCFURLVolumeSupportsAccessPermissionsKey { get; }

		// extern const CFStringRef kCFURLIsUbiquitousItemKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLIsUbiquitousItemKey", "__Internal")]
		unsafe CFStringRef* kCFURLIsUbiquitousItemKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemHasUnresolvedConflictsKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemHasUnresolvedConflictsKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemHasUnresolvedConflictsKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.9))) __attribute__((availability(ios, introduced=5.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use kCFURLUbiquitousItemDownloadingStatusKey instead")]
		[Field ("kCFURLUbiquitousItemIsDownloadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsDownloadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsDownloadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsDownloadingKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsDownloadingKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsUploadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsUploadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsUploadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemIsUploadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("kCFURLUbiquitousItemIsUploadingKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemIsUploadingKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemPercentDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentDownloadedKey on NSMetadataItem instead")]
		[Field ("kCFURLUbiquitousItemPercentDownloadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemPercentDownloadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemPercentUploadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataQuery and NSMetadataUbiquitousItemPercentUploadedKey on NSMetadataItem instead")]
		[Field ("kCFURLUbiquitousItemPercentUploadedKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemPercentUploadedKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingErrorKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemUploadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemUploadingErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemUploadingErrorKey { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusNotDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusNotDownloaded", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusNotDownloaded { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusDownloaded", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusDownloaded { get; }

		// extern const CFStringRef kCFURLUbiquitousItemDownloadingStatusCurrent __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("kCFURLUbiquitousItemDownloadingStatusCurrent", "__Internal")]
		unsafe CFStringRef* kCFURLUbiquitousItemDownloadingStatusCurrent { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFRunLoopMode kCFRunLoopDefaultMode;
		[Field ("kCFRunLoopDefaultMode", "__Internal")]
		unsafe CFRunLoopMode* kCFRunLoopDefaultMode { get; }

		// extern const CFRunLoopMode kCFRunLoopCommonModes;
		[Field ("kCFRunLoopCommonModes", "__Internal")]
		unsafe CFRunLoopMode* kCFRunLoopCommonModes { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFSocketCommandKey;
		[Field ("kCFSocketCommandKey", "__Internal")]
		unsafe CFStringRef* kCFSocketCommandKey { get; }

		// extern const CFStringRef kCFSocketNameKey;
		[Field ("kCFSocketNameKey", "__Internal")]
		unsafe CFStringRef* kCFSocketNameKey { get; }

		// extern const CFStringRef kCFSocketValueKey;
		[Field ("kCFSocketValueKey", "__Internal")]
		unsafe CFStringRef* kCFSocketValueKey { get; }

		// extern const CFStringRef kCFSocketResultKey;
		[Field ("kCFSocketResultKey", "__Internal")]
		unsafe CFStringRef* kCFSocketResultKey { get; }

		// extern const CFStringRef kCFSocketErrorKey;
		[Field ("kCFSocketErrorKey", "__Internal")]
		unsafe CFStringRef* kCFSocketErrorKey { get; }

		// extern const CFStringRef kCFSocketRegisterCommand;
		[Field ("kCFSocketRegisterCommand", "__Internal")]
		unsafe CFStringRef* kCFSocketRegisterCommand { get; }

		// extern const CFStringRef kCFSocketRetrieveCommand;
		[Field ("kCFSocketRetrieveCommand", "__Internal")]
		unsafe CFStringRef* kCFSocketRetrieveCommand { get; }
	}

	// typedef void (^os_block_t)();
	delegate void os_block_t ();

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern char * optarg;
		[Field ("optarg", "__Internal")]
		unsafe sbyte* optarg { get; }

		// extern int optind;
		[Field ("optind", "__Internal")]
		int optind { get; }

		// extern int opterr;
		[Field ("opterr", "__Internal")]
		int opterr { get; }

		// extern int optopt;
		[Field ("optopt", "__Internal")]
		int optopt { get; }

		// extern char * suboptarg;
		[Field ("suboptarg", "__Internal")]
		unsafe sbyte* suboptarg { get; }

		// extern int optreset;
		[Field ("optreset", "__Internal")]
		int optreset { get; }
	}

	// typedef void (^dispatch_block_t)();
	delegate void dispatch_block_t ();

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern struct dispatch_queue_s _dispatch_main_q __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_main_q", "__Internal")]
		dispatch_queue_s _dispatch_main_q { get; }

		// extern struct dispatch_queue_attr_s _dispatch_queue_attr_concurrent __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.3))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (4, 3)]
		[Field ("_dispatch_queue_attr_concurrent", "__Internal")]
		dispatch_queue_attr_s _dispatch_queue_attr_concurrent { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const security_token_t KERNEL_SECURITY_TOKEN;
		[Field ("KERNEL_SECURITY_TOKEN", "__Internal")]
		security_token_t KERNEL_SECURITY_TOKEN { get; }

		// extern const audit_token_t KERNEL_AUDIT_TOKEN;
		[Field ("KERNEL_AUDIT_TOKEN", "__Internal")]
		audit_token_t KERNEL_AUDIT_TOKEN { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const struct dispatch_source_type_s _dispatch_source_type_data_add __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_data_add", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_add { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_data_or __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_data_or", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_or { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_data_replace __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((visibility("default")));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("_dispatch_source_type_data_replace", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_data_replace { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_mach_send __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_mach_send", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_mach_send { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_mach_recv __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_mach_recv", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_mach_recv { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_memorypressure __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((visibility("default")));
		[Mac (10, 9), iOS (8, 0)]
		[Field ("_dispatch_source_type_memorypressure", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_memorypressure { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_proc __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_proc", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_proc { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_read __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_read", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_read { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_signal __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_signal", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_signal { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_timer __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_timer", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_timer { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_vnode __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_vnode", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_vnode { get; }

		// extern const struct dispatch_source_type_s _dispatch_source_type_write __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((visibility("default")));
		[Mac (10, 6), iOS (4, 0)]
		[Field ("_dispatch_source_type_write", "__Internal")]
		dispatch_source_type_s _dispatch_source_type_write { get; }

		// extern struct dispatch_data_s _dispatch_data_empty __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (5, 0)]
		[Field ("_dispatch_data_empty", "__Internal")]
		dispatch_data_s _dispatch_data_empty { get; }

		// extern const dispatch_block_t _Nonnull _dispatch_data_destructor_free __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((visibility("default")));
		[Mac (10, 7), iOS (5, 0)]
		[Field ("_dispatch_data_destructor_free", "__Internal")]
		dispatch_block_t _dispatch_data_destructor_free { get; }

		// extern const dispatch_block_t _Nonnull _dispatch_data_destructor_munmap __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((visibility("default")));
		[Mac (10, 9), iOS (7, 0)]
		[Field ("_dispatch_data_destructor_munmap", "__Internal")]
		dispatch_block_t _dispatch_data_destructor_munmap { get; }
	}

	// typedef _Bool (^dispatch_data_applier_t)(dispatch_data_t _Nonnull, size_t, const void * _Nonnull, size_t);
	unsafe delegate bool dispatch_data_applier_t (dispatch_data_t* arg0, nuint arg1, void* arg2, nuint arg3);

	// typedef void (^dispatch_io_handler_t)(_Bool, dispatch_data_t _Nullable, int);
	unsafe delegate void dispatch_io_handler_t (bool arg0, [NullAllowed] dispatch_data_t* arg1, int arg2);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyDataWritten;
		[Field ("kCFStreamPropertyDataWritten", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyDataWritten { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyAppendToFile;
		[Field ("kCFStreamPropertyAppendToFile", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyAppendToFile { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertyFileCurrentOffset;
		[Field ("kCFStreamPropertyFileCurrentOffset", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertyFileCurrentOffset { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketNativeHandle;
		[Field ("kCFStreamPropertySocketNativeHandle", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketNativeHandle { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketRemoteHostName;
		[Field ("kCFStreamPropertySocketRemoteHostName", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketRemoteHostName { get; }

		// extern CFStreamPropertyKey  _Null_unspecified const kCFStreamPropertySocketRemotePortNumber;
		[Field ("kCFStreamPropertySocketRemotePortNumber", "__Internal")]
		unsafe CFStreamPropertyKey* kCFStreamPropertySocketRemotePortNumber { get; }

		// extern const int kCFStreamErrorDomainSOCKS __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainSOCKS", "__Internal")]
		int kCFStreamErrorDomainSOCKS { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxy __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxy", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxy { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxyHost __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxyHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxyHost { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSProxyPort __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSProxyPort", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSProxyPort { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSVersion __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSVersion", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSVersion { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSOCKSVersion4 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSOCKSVersion4", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSOCKSVersion4 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSOCKSVersion5 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSOCKSVersion5", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSOCKSVersion5 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSUser __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSUser", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSUser { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySOCKSPassword __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySOCKSPassword", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySOCKSPassword { get; }

		// extern const int kCFStreamErrorDomainSSL __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainSSL", "__Internal")]
		int kCFStreamErrorDomainSSL { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertySocketSecurityLevel __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySocketSecurityLevel", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySocketSecurityLevel { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelNone __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelNone", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelNone { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelSSLv2 __attribute__((availability(ios, introduced=2.0, deprecated=10.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Field ("kCFStreamSocketSecurityLevelSSLv2", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelSSLv2 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelSSLv3 __attribute__((availability(ios, introduced=2.0, deprecated=10.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 10, 0)]
		[Field ("kCFStreamSocketSecurityLevelSSLv3", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelSSLv3 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelTLSv1 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelTLSv1", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelTLSv1 { get; }

		// extern CFStringRef  _Nonnull const kCFStreamSocketSecurityLevelNegotiatedSSL __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSocketSecurityLevelNegotiatedSSL", "__Internal")]
		unsafe CFStringRef* kCFStreamSocketSecurityLevelNegotiatedSSL { get; }

		// extern CFStringRef  _Nonnull const kCFStreamPropertyShouldCloseNativeSocket __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertyShouldCloseNativeSocket", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyShouldCloseNativeSocket { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFSetCallBacks kCFTypeSetCallBacks;
		[Field ("kCFTypeSetCallBacks", "__Internal")]
		CFSetCallBacks kCFTypeSetCallBacks { get; }

		// extern const CFSetCallBacks kCFCopyStringSetCallBacks;
		[Field ("kCFCopyStringSetCallBacks", "__Internal")]
		CFSetCallBacks kCFCopyStringSetCallBacks { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFURLFileExists __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLResourceIsReachable instead.")]
		[Field ("kCFURLFileExists", "__Internal")]
		unsafe CFStringRef* kCFURLFileExists { get; }

		// extern const CFStringRef kCFURLFileDirectoryContents __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use the CFURLEnumerator API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use the CFURLEnumerator API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use the CFURLEnumerator API instead.")]
		[Field ("kCFURLFileDirectoryContents", "__Internal")]
		unsafe CFStringRef* kCFURLFileDirectoryContents { get; }

		// extern const CFStringRef kCFURLFileLength __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSizeKey instead.")]
		[Field ("kCFURLFileLength", "__Internal")]
		unsafe CFStringRef* kCFURLFileLength { get; }

		// extern const CFStringRef kCFURLFileLastModificationTime __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLContentModificationDateKey instead.")]
		[Field ("kCFURLFileLastModificationTime", "__Internal")]
		unsafe CFStringRef* kCFURLFileLastModificationTime { get; }

		// extern const CFStringRef kCFURLFilePOSIXMode __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Field ("kCFURLFilePOSIXMode", "__Internal")]
		unsafe CFStringRef* kCFURLFilePOSIXMode { get; }

		// extern const CFStringRef kCFURLFileOwnerID __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use CFURLCopyResourcePropertyForKey with kCFURLFileSecurityKey and then the CFFileSecurity API instead.")]
		[Field ("kCFURLFileOwnerID", "__Internal")]
		unsafe CFStringRef* kCFURLFileOwnerID { get; }

		// extern const CFStringRef kCFURLHTTPStatusCode __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Field ("kCFURLHTTPStatusCode", "__Internal")]
		unsafe CFStringRef* kCFURLHTTPStatusCode { get; }

		// extern const CFStringRef kCFURLHTTPStatusLine __attribute__((availability(macos, introduced=10.0, deprecated=10.9))) __attribute__((availability(ios, introduced=2.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSHTTPURLResponse methods instead.")]
		[Field ("kCFURLHTTPStatusLine", "__Internal")]
		unsafe CFStringRef* kCFURLHTTPStatusLine { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFBundleInfoDictionaryVersionKey;
		[Field ("kCFBundleInfoDictionaryVersionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleInfoDictionaryVersionKey { get; }

		// extern const CFStringRef kCFBundleExecutableKey;
		[Field ("kCFBundleExecutableKey", "__Internal")]
		unsafe CFStringRef* kCFBundleExecutableKey { get; }

		// extern const CFStringRef kCFBundleIdentifierKey;
		[Field ("kCFBundleIdentifierKey", "__Internal")]
		unsafe CFStringRef* kCFBundleIdentifierKey { get; }

		// extern const CFStringRef kCFBundleVersionKey;
		[Field ("kCFBundleVersionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleVersionKey { get; }

		// extern const CFStringRef kCFBundleDevelopmentRegionKey;
		[Field ("kCFBundleDevelopmentRegionKey", "__Internal")]
		unsafe CFStringRef* kCFBundleDevelopmentRegionKey { get; }

		// extern const CFStringRef kCFBundleNameKey;
		[Field ("kCFBundleNameKey", "__Internal")]
		unsafe CFStringRef* kCFBundleNameKey { get; }

		// extern const CFStringRef kCFBundleLocalizationsKey;
		[Field ("kCFBundleLocalizationsKey", "__Internal")]
		unsafe CFStringRef* kCFBundleLocalizationsKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFPlugInDynamicRegistrationKey;
		[Field ("kCFPlugInDynamicRegistrationKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInDynamicRegistrationKey { get; }

		// extern const CFStringRef kCFPlugInDynamicRegisterFunctionKey;
		[Field ("kCFPlugInDynamicRegisterFunctionKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInDynamicRegisterFunctionKey { get; }

		// extern const CFStringRef kCFPlugInUnloadFunctionKey;
		[Field ("kCFPlugInUnloadFunctionKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInUnloadFunctionKey { get; }

		// extern const CFStringRef kCFPlugInFactoriesKey;
		[Field ("kCFPlugInFactoriesKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInFactoriesKey { get; }

		// extern const CFStringRef kCFPlugInTypesKey;
		[Field ("kCFPlugInTypesKey", "__Internal")]
		unsafe CFStringRef* kCFPlugInTypesKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef kCFUserNotificationIconURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationIconURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationIconURLKey { get; }

		// extern const CFStringRef kCFUserNotificationSoundURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationSoundURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationSoundURLKey { get; }

		// extern const CFStringRef kCFUserNotificationLocalizationURLKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationLocalizationURLKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationLocalizationURLKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertHeaderKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertHeaderKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertHeaderKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertMessageKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertMessageKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertMessageKey { get; }

		// extern const CFStringRef kCFUserNotificationDefaultButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationDefaultButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationDefaultButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationAlternateButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlternateButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlternateButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationOtherButtonTitleKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationOtherButtonTitleKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationOtherButtonTitleKey { get; }

		// extern const CFStringRef kCFUserNotificationProgressIndicatorValueKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationProgressIndicatorValueKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationProgressIndicatorValueKey { get; }

		// extern const CFStringRef kCFUserNotificationPopUpTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationPopUpTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationPopUpTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationTextFieldTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationTextFieldTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationTextFieldTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationCheckBoxTitlesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationCheckBoxTitlesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationCheckBoxTitlesKey { get; }

		// extern const CFStringRef kCFUserNotificationTextFieldValuesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationTextFieldValuesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationTextFieldValuesKey { get; }

		// extern const CFStringRef kCFUserNotificationPopUpSelectionKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 3)]
		[Field ("kCFUserNotificationPopUpSelectionKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationPopUpSelectionKey { get; }

		// extern const CFStringRef kCFUserNotificationAlertTopMostKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationAlertTopMostKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationAlertTopMostKey { get; }

		// extern const CFStringRef kCFUserNotificationKeyboardTypesKey __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 0)]
		[Field ("kCFUserNotificationKeyboardTypesKey", "__Internal")]
		unsafe CFStringRef* kCFUserNotificationKeyboardTypesKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double NSFoundationVersionNumber;
		[Field ("NSFoundationVersionNumber", "__Internal")]
		double NSFoundationVersionNumber { get; }
	}

	// typedef NSComparisonResult (^NSComparator)(id _Nonnull, id _Nonnull);
	unsafe delegate nint NSComparator (id* arg0, id* arg1);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSValue;
		[Field ("NSValue", "__Internal")]
		int NSValue { get; }

		// extern int NSValue;
		[Field ("NSValue", "__Internal")]
		int NSValue { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }

		// extern int NSNumber;
		[Field ("NSNumber", "__Internal")]
		int NSNumber { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSOrderedCollectionChange;
		[Field ("NSOrderedCollectionChange", "__Internal")]
		int NSOrderedCollectionChange { get; }

		// extern int NSOrderedCollectionChange;
		[Field ("NSOrderedCollectionChange", "__Internal")]
		int NSOrderedCollectionChange { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSOrderedCollectionDifference;
		[Field ("NSOrderedCollectionDifference", "__Internal")]
		int NSOrderedCollectionDifference { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int ObjectType;
		[Field ("ObjectType", "__Internal")]
		int ObjectType { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int ObjectType;
		[Field ("ObjectType", "__Internal")]
		int ObjectType { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSOrderedCollectionDifference;
		[Field ("NSOrderedCollectionDifference", "__Internal")]
		int NSOrderedCollectionDifference { get; }

		// extern int NSOrderedCollectionDifference;
		[Field ("NSOrderedCollectionDifference", "__Internal")]
		int NSOrderedCollectionDifference { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int unichar;
		[Field ("unichar", "__Internal")]
		int unichar { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToKatakana __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToKatakana", "__Internal")]
		unsafe int* NSStringTransformLatinToKatakana { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToHiragana __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToHiragana", "__Internal")]
		unsafe int* NSStringTransformLatinToHiragana { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToHangul __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToHangul", "__Internal")]
		unsafe int* NSStringTransformLatinToHangul { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToArabic __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToArabic", "__Internal")]
		unsafe int* NSStringTransformLatinToArabic { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToHebrew __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToHebrew", "__Internal")]
		unsafe int* NSStringTransformLatinToHebrew { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToThai __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToThai", "__Internal")]
		unsafe int* NSStringTransformLatinToThai { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToCyrillic __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToCyrillic", "__Internal")]
		unsafe int* NSStringTransformLatinToCyrillic { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformLatinToGreek __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformLatinToGreek", "__Internal")]
		unsafe int* NSStringTransformLatinToGreek { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformToLatin __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformToLatin", "__Internal")]
		unsafe int* NSStringTransformToLatin { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformMandarinToLatin __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformMandarinToLatin", "__Internal")]
		unsafe int* NSStringTransformMandarinToLatin { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformHiraganaToKatakana __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformHiraganaToKatakana", "__Internal")]
		unsafe int* NSStringTransformHiraganaToKatakana { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformFullwidthToHalfwidth __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformFullwidthToHalfwidth", "__Internal")]
		unsafe int* NSStringTransformFullwidthToHalfwidth { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformToXMLHex __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformToXMLHex", "__Internal")]
		unsafe int* NSStringTransformToXMLHex { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformToUnicodeName __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformToUnicodeName", "__Internal")]
		unsafe int* NSStringTransformToUnicodeName { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformStripCombiningMarks __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformStripCombiningMarks", "__Internal")]
		unsafe int* NSStringTransformStripCombiningMarks { get; }

		// extern const NSStringTransform _Nonnull NSStringTransformStripDiacritics __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSStringTransformStripDiacritics", "__Internal")]
		unsafe int* NSStringTransformStripDiacritics { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSMutableString;
		[Field ("NSMutableString", "__Internal")]
		int NSMutableString { get; }

		// extern int NSMutableString;
		[Field ("NSMutableString", "__Internal")]
		int NSMutableString { get; }

		// extern const NSExceptionName _Nonnull NSParseErrorException;
		[Field ("NSParseErrorException", "__Internal")]
		unsafe int* NSParseErrorException { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSProgress;
		[Field ("NSProgress", "__Internal")]
		int NSProgress { get; }

		// extern int NSProgress;
		[Field ("NSProgress", "__Internal")]
		int NSProgress { get; }

		// extern int NSProgress;
		[Field ("NSProgress", "__Internal")]
		int NSProgress { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	// typedef void (^NSProgressUnpublishingHandler)();
	delegate void NSProgressUnpublishingHandler ();

	// typedef NSProgressUnpublishingHandler _Nullable (^NSProgressPublishingHandler)(int * _Nonnull);
	unsafe delegate NSProgressUnpublishingHandler NSProgressPublishingHandler (int* arg0);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressThroughputKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressThroughputKey", "__Internal")]
		unsafe int* NSProgressThroughputKey { get; }

		// extern const NSProgressKind _Nonnull NSProgressKindFile __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressKindFile", "__Internal")]
		unsafe int* NSProgressKindFile { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileOperationKindKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileOperationKindKey", "__Internal")]
		unsafe int* NSProgressFileOperationKindKey { get; }

		// extern const NSProgressFileOperationKind _Nonnull NSProgressFileOperationKindDownloading __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileOperationKindDownloading", "__Internal")]
		unsafe int* NSProgressFileOperationKindDownloading { get; }

		// extern const NSProgressFileOperationKind _Nonnull NSProgressFileOperationKindDecompressingAfterDownloading __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileOperationKindDecompressingAfterDownloading", "__Internal")]
		unsafe int* NSProgressFileOperationKindDecompressingAfterDownloading { get; }

		// extern const NSProgressFileOperationKind _Nonnull NSProgressFileOperationKindReceiving __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileOperationKindReceiving", "__Internal")]
		unsafe int* NSProgressFileOperationKindReceiving { get; }

		// extern const NSProgressFileOperationKind _Nonnull NSProgressFileOperationKindCopying __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileOperationKindCopying", "__Internal")]
		unsafe int* NSProgressFileOperationKindCopying { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileURLKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileURLKey", "__Internal")]
		unsafe int* NSProgressFileURLKey { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileTotalCountKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileTotalCountKey", "__Internal")]
		unsafe int* NSProgressFileTotalCountKey { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileCompletedCountKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSProgressFileCompletedCountKey", "__Internal")]
		unsafe int* NSProgressFileCompletedCountKey { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileAnimationImageKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSProgressFileAnimationImageKey", "__Internal")]
		unsafe int* NSProgressFileAnimationImageKey { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileAnimationImageOriginalRectKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSProgressFileAnimationImageOriginalRectKey", "__Internal")]
		unsafe int* NSProgressFileAnimationImageOriginalRectKey { get; }

		// extern const NSProgressUserInfoKey _Nonnull NSProgressFileIconKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSProgressFileIconKey", "__Internal")]
		unsafe int* NSProgressFileIconKey { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSBundle;
		[Field ("NSBundle", "__Internal")]
		int NSBundle { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int *const _Nonnull NSLoadedClasses;
		[Field ("NSLoadedClasses", "__Internal")]
		unsafe int* NSLoadedClasses { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const double NSBundleResourceRequestLoadingPriorityUrgent __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSBundleResourceRequestLoadingPriorityUrgent", "__Internal")]
		double NSBundleResourceRequestLoadingPriorityUrgent { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSNotificationName _Nonnull NSSystemClockDidChangeNotification __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSSystemClockDidChangeNotification", "__Internal")]
		unsafe int* NSSystemClockDidChangeNotification { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSDate;
		[Field ("NSDate", "__Internal")]
		int NSDate { get; }

		// extern int NSDate;
		[Field ("NSDate", "__Internal")]
		int NSDate { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierGregorian __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierGregorian", "__Internal")]
		unsafe int* NSCalendarIdentifierGregorian { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierBuddhist __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierBuddhist", "__Internal")]
		unsafe int* NSCalendarIdentifierBuddhist { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierChinese __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierChinese", "__Internal")]
		unsafe int* NSCalendarIdentifierChinese { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierCoptic __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierCoptic", "__Internal")]
		unsafe int* NSCalendarIdentifierCoptic { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierEthiopicAmeteMihret __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierEthiopicAmeteMihret", "__Internal")]
		unsafe int* NSCalendarIdentifierEthiopicAmeteMihret { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierEthiopicAmeteAlem __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierEthiopicAmeteAlem", "__Internal")]
		unsafe int* NSCalendarIdentifierEthiopicAmeteAlem { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierHebrew __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierHebrew", "__Internal")]
		unsafe int* NSCalendarIdentifierHebrew { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierISO8601 __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierISO8601", "__Internal")]
		unsafe int* NSCalendarIdentifierISO8601 { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierIndian __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierIndian", "__Internal")]
		unsafe int* NSCalendarIdentifierIndian { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierIslamic __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierIslamic", "__Internal")]
		unsafe int* NSCalendarIdentifierIslamic { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierIslamicCivil __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierIslamicCivil", "__Internal")]
		unsafe int* NSCalendarIdentifierIslamicCivil { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierJapanese __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierJapanese", "__Internal")]
		unsafe int* NSCalendarIdentifierJapanese { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierPersian __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierPersian", "__Internal")]
		unsafe int* NSCalendarIdentifierPersian { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierRepublicOfChina __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSCalendarIdentifierRepublicOfChina", "__Internal")]
		unsafe int* NSCalendarIdentifierRepublicOfChina { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierIslamicTabular __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSCalendarIdentifierIslamicTabular", "__Internal")]
		unsafe int* NSCalendarIdentifierIslamicTabular { get; }

		// extern const NSCalendarIdentifier _Nonnull NSCalendarIdentifierIslamicUmmAlQura __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSCalendarIdentifierIslamicUmmAlQura", "__Internal")]
		unsafe int* NSCalendarIdentifierIslamicUmmAlQura { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDateComponents;
		[Field ("NSDateComponents", "__Internal")]
		int NSDateComponents { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDateComponents;
		[Field ("NSDateComponents", "__Internal")]
		int NSDateComponents { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDate;
		[Field ("NSDate", "__Internal")]
		int NSDate { get; }

		// extern int NSDateComponents;
		[Field ("NSDateComponents", "__Internal")]
		int NSDateComponents { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSDateComponents;
		[Field ("NSDateComponents", "__Internal")]
		int NSDateComponents { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSCharacterSet;
		[Field ("NSCharacterSet", "__Internal")]
		int NSCharacterSet { get; }

		// extern int NSCharacterSet;
		[Field ("NSCharacterSet", "__Internal")]
		int NSCharacterSet { get; }

		// extern int NSCharacterSet;
		[Field ("NSCharacterSet", "__Internal")]
		int NSCharacterSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int NSMutableCharacterSet;
		[Field ("NSMutableCharacterSet", "__Internal")]
		int NSMutableCharacterSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int int32_t;
		[Field ("int32_t", "__Internal")]
		int int32_t { get; }

		// extern int int64_t;
		[Field ("int64_t", "__Internal")]
		int int64_t { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSData;
		[Field ("NSData", "__Internal")]
		int NSData { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSData;
		[Field ("NSData", "__Internal")]
		int NSData { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSAttributedString;
		[Field ("NSAttributedString", "__Internal")]
		int NSAttributedString { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSUnitConcentrationMass;
		[Field ("NSUnitConcentrationMass", "__Internal")]
		int NSUnitConcentrationMass { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSMeasurement;
		[Field ("NSMeasurement", "__Internal")]
		int NSMeasurement { get; }

		// extern int NSMeasurement;
		[Field ("NSMeasurement", "__Internal")]
		int NSMeasurement { get; }

		// extern int NSMeasurement;
		[Field ("NSMeasurement", "__Internal")]
		int NSMeasurement { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSNumberFormatterBehavior;
		[Field ("NSNumberFormatterBehavior", "__Internal")]
		int NSNumberFormatterBehavior { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int uint32_t;
		[Field ("uint32_t", "__Internal")]
		int uint32_t { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSLocaleLanguageDirection;
		[Field ("NSLocaleLanguageDirection", "__Internal")]
		int NSLocaleLanguageDirection { get; }

		// extern int NSLocaleLanguageDirection;
		[Field ("NSLocaleLanguageDirection", "__Internal")]
		int NSLocaleLanguageDirection { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleIdentifier;
		[Field ("NSLocaleIdentifier", "__Internal")]
		unsafe int* NSLocaleIdentifier { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleLanguageCode;
		[Field ("NSLocaleLanguageCode", "__Internal")]
		unsafe int* NSLocaleLanguageCode { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCountryCode;
		[Field ("NSLocaleCountryCode", "__Internal")]
		unsafe int* NSLocaleCountryCode { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleScriptCode;
		[Field ("NSLocaleScriptCode", "__Internal")]
		unsafe int* NSLocaleScriptCode { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleVariantCode;
		[Field ("NSLocaleVariantCode", "__Internal")]
		unsafe int* NSLocaleVariantCode { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleExemplarCharacterSet;
		[Field ("NSLocaleExemplarCharacterSet", "__Internal")]
		unsafe int* NSLocaleExemplarCharacterSet { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCalendar;
		[Field ("NSLocaleCalendar", "__Internal")]
		unsafe int* NSLocaleCalendar { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCollationIdentifier;
		[Field ("NSLocaleCollationIdentifier", "__Internal")]
		unsafe int* NSLocaleCollationIdentifier { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleUsesMetricSystem;
		[Field ("NSLocaleUsesMetricSystem", "__Internal")]
		unsafe int* NSLocaleUsesMetricSystem { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleMeasurementSystem;
		[Field ("NSLocaleMeasurementSystem", "__Internal")]
		unsafe int* NSLocaleMeasurementSystem { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleDecimalSeparator;
		[Field ("NSLocaleDecimalSeparator", "__Internal")]
		unsafe int* NSLocaleDecimalSeparator { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleGroupingSeparator;
		[Field ("NSLocaleGroupingSeparator", "__Internal")]
		unsafe int* NSLocaleGroupingSeparator { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCurrencySymbol;
		[Field ("NSLocaleCurrencySymbol", "__Internal")]
		unsafe int* NSLocaleCurrencySymbol { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCurrencyCode;
		[Field ("NSLocaleCurrencyCode", "__Internal")]
		unsafe int* NSLocaleCurrencyCode { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleCollatorIdentifier __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSLocaleCollatorIdentifier", "__Internal")]
		unsafe int* NSLocaleCollatorIdentifier { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSLocaleQuotationBeginDelimiterKey", "__Internal")]
		unsafe int* NSLocaleQuotationBeginDelimiterKey { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSLocaleQuotationEndDelimiterKey", "__Internal")]
		unsafe int* NSLocaleQuotationEndDelimiterKey { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleAlternateQuotationBeginDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSLocaleAlternateQuotationBeginDelimiterKey", "__Internal")]
		unsafe int* NSLocaleAlternateQuotationBeginDelimiterKey { get; }

		// extern const NSLocaleKey _Nonnull NSLocaleAlternateQuotationEndDelimiterKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSLocaleAlternateQuotationEndDelimiterKey", "__Internal")]
		unsafe int* NSLocaleAlternateQuotationEndDelimiterKey { get; }

		// extern int *const _Nonnull NSGregorianCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSGregorianCalendar", "__Internal")]
		unsafe int* NSGregorianCalendar { get; }

		// extern int *const _Nonnull NSBuddhistCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSBuddhistCalendar", "__Internal")]
		unsafe int* NSBuddhistCalendar { get; }

		// extern int *const _Nonnull NSChineseCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSChineseCalendar", "__Internal")]
		unsafe int* NSChineseCalendar { get; }

		// extern int *const _Nonnull NSHebrewCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSHebrewCalendar", "__Internal")]
		unsafe int* NSHebrewCalendar { get; }

		// extern int *const _Nonnull NSIslamicCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSIslamicCalendar", "__Internal")]
		unsafe int* NSIslamicCalendar { get; }

		// extern int *const _Nonnull NSIslamicCivilCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSIslamicCivilCalendar", "__Internal")]
		unsafe int* NSIslamicCivilCalendar { get; }

		// extern int *const _Nonnull NSJapaneseCalendar __attribute__((availability(macos, introduced=10.4, deprecated=10.10))) __attribute__((availability(ios, introduced=2.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 4)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSJapaneseCalendar", "__Internal")]
		unsafe int* NSJapaneseCalendar { get; }

		// extern int *const _Nonnull NSRepublicOfChinaCalendar __attribute__((availability(macos, introduced=10.6, deprecated=10.10))) __attribute__((availability(ios, introduced=4.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 6)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 4, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSRepublicOfChinaCalendar", "__Internal")]
		unsafe int* NSRepublicOfChinaCalendar { get; }

		// extern int *const _Nonnull NSPersianCalendar __attribute__((availability(macos, introduced=10.6, deprecated=10.10))) __attribute__((availability(ios, introduced=4.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 6)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 4, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSPersianCalendar", "__Internal")]
		unsafe int* NSPersianCalendar { get; }

		// extern int *const _Nonnull NSIndianCalendar __attribute__((availability(macos, introduced=10.6, deprecated=10.10))) __attribute__((availability(ios, introduced=4.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 6)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 4, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSIndianCalendar", "__Internal")]
		unsafe int* NSIndianCalendar { get; }

		// extern int *const _Nonnull NSISO8601Calendar __attribute__((availability(macos, introduced=10.6, deprecated=10.10))) __attribute__((availability(ios, introduced=4.0, deprecated=8.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 6)]
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Introduced (PlatformName.iOS, 4, 0)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 2, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Field ("NSISO8601Calendar", "__Internal")]
		unsafe int* NSISO8601Calendar { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSAttributedString;
		[Field ("NSAttributedString", "__Internal")]
		int NSAttributedString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int *const _Nonnull NSPersonNameComponentGivenName __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentGivenName", "__Internal")]
		unsafe int* NSPersonNameComponentGivenName { get; }

		// extern int *const _Nonnull NSPersonNameComponentFamilyName __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentFamilyName", "__Internal")]
		unsafe int* NSPersonNameComponentFamilyName { get; }

		// extern int *const _Nonnull NSPersonNameComponentMiddleName __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentMiddleName", "__Internal")]
		unsafe int* NSPersonNameComponentMiddleName { get; }

		// extern int *const _Nonnull NSPersonNameComponentPrefix __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentPrefix", "__Internal")]
		unsafe int* NSPersonNameComponentPrefix { get; }

		// extern int *const _Nonnull NSPersonNameComponentSuffix __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentSuffix", "__Internal")]
		unsafe int* NSPersonNameComponentSuffix { get; }

		// extern int *const _Nonnull NSPersonNameComponentNickname __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentNickname", "__Internal")]
		unsafe int* NSPersonNameComponentNickname { get; }

		// extern int *const _Nonnull NSPersonNameComponentDelimiter __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSPersonNameComponentDelimiter", "__Internal")]
		unsafe int* NSPersonNameComponentDelimiter { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSExceptionName _Nonnull NSGenericException;
		[Field ("NSGenericException", "__Internal")]
		unsafe int* NSGenericException { get; }

		// extern const NSExceptionName _Nonnull NSRangeException;
		[Field ("NSRangeException", "__Internal")]
		unsafe int* NSRangeException { get; }

		// extern const NSExceptionName _Nonnull NSInvalidArgumentException;
		[Field ("NSInvalidArgumentException", "__Internal")]
		unsafe int* NSInvalidArgumentException { get; }

		// extern const NSExceptionName _Nonnull NSInternalInconsistencyException;
		[Field ("NSInternalInconsistencyException", "__Internal")]
		unsafe int* NSInternalInconsistencyException { get; }

		// extern const NSExceptionName _Nonnull NSMallocException;
		[Field ("NSMallocException", "__Internal")]
		unsafe int* NSMallocException { get; }

		// extern const NSExceptionName _Nonnull NSObjectInaccessibleException;
		[Field ("NSObjectInaccessibleException", "__Internal")]
		unsafe int* NSObjectInaccessibleException { get; }

		// extern const NSExceptionName _Nonnull NSObjectNotAvailableException;
		[Field ("NSObjectNotAvailableException", "__Internal")]
		unsafe int* NSObjectNotAvailableException { get; }

		// extern const NSExceptionName _Nonnull NSDestinationInvalidException;
		[Field ("NSDestinationInvalidException", "__Internal")]
		unsafe int* NSDestinationInvalidException { get; }

		// extern const NSExceptionName _Nonnull NSPortTimeoutException;
		[Field ("NSPortTimeoutException", "__Internal")]
		unsafe int* NSPortTimeoutException { get; }

		// extern const NSExceptionName _Nonnull NSInvalidSendPortException;
		[Field ("NSInvalidSendPortException", "__Internal")]
		unsafe int* NSInvalidSendPortException { get; }

		// extern const NSExceptionName _Nonnull NSInvalidReceivePortException;
		[Field ("NSInvalidReceivePortException", "__Internal")]
		unsafe int* NSInvalidReceivePortException { get; }

		// extern const NSExceptionName _Nonnull NSPortSendException;
		[Field ("NSPortSendException", "__Internal")]
		unsafe int* NSPortSendException { get; }

		// extern const NSExceptionName _Nonnull NSPortReceiveException;
		[Field ("NSPortReceiveException", "__Internal")]
		unsafe int* NSPortReceiveException { get; }

		// extern const NSExceptionName _Nonnull NSOldStyleException;
		[Field ("NSOldStyleException", "__Internal")]
		unsafe int* NSOldStyleException { get; }

		// extern const NSExceptionName _Nonnull NSInconsistentArchiveException;
		[Field ("NSInconsistentArchiveException", "__Internal")]
		unsafe int* NSInconsistentArchiveException { get; }

		// extern int NSException;
		[Field ("NSException", "__Internal")]
		int NSException { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int *const _Nonnull NSAssertionHandlerKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSAssertionHandlerKey", "__Internal")]
		unsafe int* NSAssertionHandlerKey { get; }

		// extern const NSExceptionName _Nonnull NSDecimalNumberOverflowException;
		[Field ("NSDecimalNumberOverflowException", "__Internal")]
		unsafe int* NSDecimalNumberOverflowException { get; }

		// extern const NSExceptionName _Nonnull NSDecimalNumberUnderflowException;
		[Field ("NSDecimalNumberUnderflowException", "__Internal")]
		unsafe int* NSDecimalNumberUnderflowException { get; }

		// extern const NSExceptionName _Nonnull NSDecimalNumberDivideByZeroException;
		[Field ("NSDecimalNumberDivideByZeroException", "__Internal")]
		unsafe int* NSDecimalNumberDivideByZeroException { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSDecimalNumber;
		[Field ("NSDecimalNumber", "__Internal")]
		int NSDecimalNumber { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSErrorDomain _Nonnull NSCocoaErrorDomain;
		[Field ("NSCocoaErrorDomain", "__Internal")]
		unsafe int* NSCocoaErrorDomain { get; }

		// extern const NSErrorDomain _Nonnull NSPOSIXErrorDomain;
		[Field ("NSPOSIXErrorDomain", "__Internal")]
		unsafe int* NSPOSIXErrorDomain { get; }

		// extern const NSErrorDomain _Nonnull NSOSStatusErrorDomain;
		[Field ("NSOSStatusErrorDomain", "__Internal")]
		unsafe int* NSOSStatusErrorDomain { get; }

		// extern const NSErrorDomain _Nonnull NSMachErrorDomain;
		[Field ("NSMachErrorDomain", "__Internal")]
		unsafe int* NSMachErrorDomain { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSUnderlyingErrorKey;
		[Field ("NSUnderlyingErrorKey", "__Internal")]
		unsafe int* NSUnderlyingErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSLocalizedDescriptionKey;
		[Field ("NSLocalizedDescriptionKey", "__Internal")]
		unsafe int* NSLocalizedDescriptionKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSLocalizedFailureReasonErrorKey;
		[Field ("NSLocalizedFailureReasonErrorKey", "__Internal")]
		unsafe int* NSLocalizedFailureReasonErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSLocalizedRecoverySuggestionErrorKey;
		[Field ("NSLocalizedRecoverySuggestionErrorKey", "__Internal")]
		unsafe int* NSLocalizedRecoverySuggestionErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSLocalizedRecoveryOptionsErrorKey;
		[Field ("NSLocalizedRecoveryOptionsErrorKey", "__Internal")]
		unsafe int* NSLocalizedRecoveryOptionsErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSRecoveryAttempterErrorKey;
		[Field ("NSRecoveryAttempterErrorKey", "__Internal")]
		unsafe int* NSRecoveryAttempterErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSHelpAnchorErrorKey;
		[Field ("NSHelpAnchorErrorKey", "__Internal")]
		unsafe int* NSHelpAnchorErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSDebugDescriptionErrorKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSDebugDescriptionErrorKey", "__Internal")]
		unsafe int* NSDebugDescriptionErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSLocalizedFailureErrorKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("NSLocalizedFailureErrorKey", "__Internal")]
		unsafe int* NSLocalizedFailureErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSStringEncodingErrorKey;
		[Field ("NSStringEncodingErrorKey", "__Internal")]
		unsafe int* NSStringEncodingErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSURLErrorKey;
		[Field ("NSURLErrorKey", "__Internal")]
		unsafe int* NSURLErrorKey { get; }

		// extern const NSErrorUserInfoKey _Nonnull NSFilePathErrorKey;
		[Field ("NSFilePathErrorKey", "__Internal")]
		unsafe int* NSFilePathErrorKey { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern const NSRunLoopMode _Nonnull NSDefaultRunLoopMode;
		[Field ("NSDefaultRunLoopMode", "__Internal")]
		unsafe int* NSDefaultRunLoopMode { get; }

		// extern const NSRunLoopMode _Nonnull NSRunLoopCommonModes __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSRunLoopCommonModes", "__Internal")]
		unsafe int* NSRunLoopCommonModes { get; }

		// extern int CFRunLoopRef;
		[Field ("CFRunLoopRef", "__Internal")]
		int CFRunLoopRef { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern const NSNotificationName _Nonnull NSFileHandleReadCompletionNotification;
		[Field ("NSFileHandleReadCompletionNotification", "__Internal")]
		unsafe int* NSFileHandleReadCompletionNotification { get; }

		// extern const NSNotificationName _Nonnull NSFileHandleReadToEndOfFileCompletionNotification;
		[Field ("NSFileHandleReadToEndOfFileCompletionNotification", "__Internal")]
		unsafe int* NSFileHandleReadToEndOfFileCompletionNotification { get; }

		// extern const NSNotificationName _Nonnull NSFileHandleConnectionAcceptedNotification;
		[Field ("NSFileHandleConnectionAcceptedNotification", "__Internal")]
		unsafe int* NSFileHandleConnectionAcceptedNotification { get; }

		// extern const NSNotificationName _Nonnull NSFileHandleDataAvailableNotification;
		[Field ("NSFileHandleDataAvailableNotification", "__Internal")]
		unsafe int* NSFileHandleDataAvailableNotification { get; }

		// extern int *const _Nonnull NSFileHandleNotificationDataItem;
		[Field ("NSFileHandleNotificationDataItem", "__Internal")]
		unsafe int* NSFileHandleNotificationDataItem { get; }

		// extern int *const _Nonnull NSFileHandleNotificationFileHandleItem;
		[Field ("NSFileHandleNotificationFileHandleItem", "__Internal")]
		unsafe int* NSFileHandleNotificationFileHandleItem { get; }

		// extern int *const _Nonnull NSFileHandleNotificationMonitorModes __attribute__((availability(macos, introduced=10.0, deprecated=10.7))) __attribute__((availability(ios, introduced=2.0, deprecated=5.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 7, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 5, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Field ("NSFileHandleNotificationMonitorModes", "__Internal")]
		unsafe int* NSFileHandleNotificationMonitorModes { get; }

		// extern int NSData;
		[Field ("NSData", "__Internal")]
		int NSData { get; }

		// extern int NSPipe;
		[Field ("NSPipe", "__Internal")]
		int NSPipe { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int * _Nonnull NSURLFileScheme;
		[Field ("NSURLFileScheme", "__Internal")]
		unsafe int* NSURLFileScheme { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern const NSURLResourceKey _Nonnull NSURLKeysOfUnsetValuesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLKeysOfUnsetValuesKey", "__Internal")]
		unsafe int* NSURLKeysOfUnsetValuesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLNameKey", "__Internal")]
		unsafe int* NSURLNameKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLocalizedNameKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLocalizedNameKey", "__Internal")]
		unsafe int* NSURLLocalizedNameKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsRegularFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsRegularFileKey", "__Internal")]
		unsafe int* NSURLIsRegularFileKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsDirectoryKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsDirectoryKey", "__Internal")]
		unsafe int* NSURLIsDirectoryKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsSymbolicLinkKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsSymbolicLinkKey", "__Internal")]
		unsafe int* NSURLIsSymbolicLinkKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsVolumeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsVolumeKey", "__Internal")]
		unsafe int* NSURLIsVolumeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsPackageKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsPackageKey", "__Internal")]
		unsafe int* NSURLIsPackageKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsApplicationKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 11), iOS (9, 0)]
		[Field ("NSURLIsApplicationKey", "__Internal")]
		unsafe int* NSURLIsApplicationKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLApplicationIsScriptableKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 11)]
		[Field ("NSURLApplicationIsScriptableKey", "__Internal")]
		unsafe int* NSURLApplicationIsScriptableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsSystemImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsSystemImmutableKey", "__Internal")]
		unsafe int* NSURLIsSystemImmutableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsUserImmutableKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsUserImmutableKey", "__Internal")]
		unsafe int* NSURLIsUserImmutableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsHiddenKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsHiddenKey", "__Internal")]
		unsafe int* NSURLIsHiddenKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLHasHiddenExtensionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLHasHiddenExtensionKey", "__Internal")]
		unsafe int* NSURLHasHiddenExtensionKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLCreationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLCreationDateKey", "__Internal")]
		unsafe int* NSURLCreationDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLContentAccessDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLContentAccessDateKey", "__Internal")]
		unsafe int* NSURLContentAccessDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLContentModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLContentModificationDateKey", "__Internal")]
		unsafe int* NSURLContentModificationDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLAttributeModificationDateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLAttributeModificationDateKey", "__Internal")]
		unsafe int* NSURLAttributeModificationDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLinkCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLinkCountKey", "__Internal")]
		unsafe int* NSURLLinkCountKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLParentDirectoryURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLParentDirectoryURLKey", "__Internal")]
		unsafe int* NSURLParentDirectoryURLKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeURLKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeURLKey", "__Internal")]
		unsafe int* NSURLVolumeURLKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLTypeIdentifierKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLTypeIdentifierKey", "__Internal")]
		unsafe int* NSURLTypeIdentifierKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLocalizedTypeDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLocalizedTypeDescriptionKey", "__Internal")]
		unsafe int* NSURLLocalizedTypeDescriptionKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLabelNumberKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLabelNumberKey", "__Internal")]
		unsafe int* NSURLLabelNumberKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLabelColorKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLabelColorKey", "__Internal")]
		unsafe int* NSURLLabelColorKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLLocalizedLabelKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLLocalizedLabelKey", "__Internal")]
		unsafe int* NSURLLocalizedLabelKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLEffectiveIconKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLEffectiveIconKey", "__Internal")]
		unsafe int* NSURLEffectiveIconKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLCustomIconKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLCustomIconKey", "__Internal")]
		unsafe int* NSURLCustomIconKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileResourceIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceIdentifierKey", "__Internal")]
		unsafe int* NSURLFileResourceIdentifierKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIdentifierKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIdentifierKey", "__Internal")]
		unsafe int* NSURLVolumeIdentifierKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLPreferredIOBlockSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLPreferredIOBlockSizeKey", "__Internal")]
		unsafe int* NSURLPreferredIOBlockSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsReadableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLIsReadableKey", "__Internal")]
		unsafe int* NSURLIsReadableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsWritableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLIsWritableKey", "__Internal")]
		unsafe int* NSURLIsWritableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsExecutableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLIsExecutableKey", "__Internal")]
		unsafe int* NSURLIsExecutableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileSecurityKey", "__Internal")]
		unsafe int* NSURLFileSecurityKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsExcludedFromBackupKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=5.1))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (5, 1)]
		[Field ("NSURLIsExcludedFromBackupKey", "__Internal")]
		unsafe int* NSURLIsExcludedFromBackupKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLTagNamesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSURLTagNamesKey", "__Internal")]
		unsafe int* NSURLTagNamesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLPathKey __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (6, 0)]
		[Field ("NSURLPathKey", "__Internal")]
		unsafe int* NSURLPathKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLCanonicalPathKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLCanonicalPathKey", "__Internal")]
		unsafe int* NSURLCanonicalPathKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsMountTriggerKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLIsMountTriggerKey", "__Internal")]
		unsafe int* NSURLIsMountTriggerKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLGenerationIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLGenerationIdentifierKey", "__Internal")]
		unsafe int* NSURLGenerationIdentifierKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLDocumentIdentifierKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLDocumentIdentifierKey", "__Internal")]
		unsafe int* NSURLDocumentIdentifierKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLAddedToDirectoryDateKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLAddedToDirectoryDateKey", "__Internal")]
		unsafe int* NSURLAddedToDirectoryDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLQuarantinePropertiesKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 10)]
		[Field ("NSURLQuarantinePropertiesKey", "__Internal")]
		unsafe int* NSURLQuarantinePropertiesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileResourceTypeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeKey", "__Internal")]
		unsafe int* NSURLFileResourceTypeKey { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeNamedPipe __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeNamedPipe", "__Internal")]
		unsafe int* NSURLFileResourceTypeNamedPipe { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeCharacterSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeCharacterSpecial", "__Internal")]
		unsafe int* NSURLFileResourceTypeCharacterSpecial { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeDirectory __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeDirectory", "__Internal")]
		unsafe int* NSURLFileResourceTypeDirectory { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeBlockSpecial __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeBlockSpecial", "__Internal")]
		unsafe int* NSURLFileResourceTypeBlockSpecial { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeRegular __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeRegular", "__Internal")]
		unsafe int* NSURLFileResourceTypeRegular { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeSymbolicLink __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeSymbolicLink", "__Internal")]
		unsafe int* NSURLFileResourceTypeSymbolicLink { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeSocket __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeSocket", "__Internal")]
		unsafe int* NSURLFileResourceTypeSocket { get; }

		// extern const NSURLFileResourceType _Nonnull NSURLFileResourceTypeUnknown __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLFileResourceTypeUnknown", "__Internal")]
		unsafe int* NSURLFileResourceTypeUnknown { get; }

		// extern const NSURLResourceKey _Nonnull NSURLThumbnailDictionaryKey __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Field ("NSURLThumbnailDictionaryKey", "__Internal")]
		unsafe int* NSURLThumbnailDictionaryKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLThumbnailKey __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[NoWatch, NoTV, NoiOS]
		[Field ("NSURLThumbnailKey", "__Internal")]
		unsafe int* NSURLThumbnailKey { get; }

		// extern const NSURLThumbnailDictionaryItem _Nonnull NSThumbnail1024x1024SizeKey __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use the QuickLookThumbnailing framework and extension point instead")]
		[Field ("NSThumbnail1024x1024SizeKey", "__Internal")]
		unsafe int* NSThumbnail1024x1024SizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLFileSizeKey", "__Internal")]
		unsafe int* NSURLFileSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLFileAllocatedSizeKey", "__Internal")]
		unsafe int* NSURLFileAllocatedSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLTotalFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLTotalFileSizeKey", "__Internal")]
		unsafe int* NSURLTotalFileSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLTotalFileAllocatedSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLTotalFileAllocatedSizeKey", "__Internal")]
		unsafe int* NSURLTotalFileAllocatedSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsAliasFileKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLIsAliasFileKey", "__Internal")]
		unsafe int* NSURLIsAliasFileKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLFileProtectionKey __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSURLFileProtectionKey", "__Internal")]
		unsafe int* NSURLFileProtectionKey { get; }

		// extern const NSURLFileProtectionType _Nonnull NSURLFileProtectionNone __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSURLFileProtectionNone", "__Internal")]
		unsafe int* NSURLFileProtectionNone { get; }

		// extern const NSURLFileProtectionType _Nonnull NSURLFileProtectionComplete __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSURLFileProtectionComplete", "__Internal")]
		unsafe int* NSURLFileProtectionComplete { get; }

		// extern const NSURLFileProtectionType _Nonnull NSURLFileProtectionCompleteUnlessOpen __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSURLFileProtectionCompleteUnlessOpen", "__Internal")]
		unsafe int* NSURLFileProtectionCompleteUnlessOpen { get; }

		// extern const NSURLFileProtectionType _Nonnull NSURLFileProtectionCompleteUntilFirstUserAuthentication __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSURLFileProtectionCompleteUntilFirstUserAuthentication", "__Internal")]
		unsafe int* NSURLFileProtectionCompleteUntilFirstUserAuthentication { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeLocalizedFormatDescriptionKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeLocalizedFormatDescriptionKey", "__Internal")]
		unsafe int* NSURLVolumeLocalizedFormatDescriptionKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeTotalCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeTotalCapacityKey", "__Internal")]
		unsafe int* NSURLVolumeTotalCapacityKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeAvailableCapacityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeAvailableCapacityKey", "__Internal")]
		unsafe int* NSURLVolumeAvailableCapacityKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeResourceCountKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeResourceCountKey", "__Internal")]
		unsafe int* NSURLVolumeResourceCountKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsPersistentIDsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsPersistentIDsKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsPersistentIDsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsSymbolicLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsSymbolicLinksKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsSymbolicLinksKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsHardLinksKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsHardLinksKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsHardLinksKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsJournalingKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsJournalingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsJournalingKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeIsJournalingKey", "__Internal")]
		unsafe int* NSURLVolumeIsJournalingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsSparseFilesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsSparseFilesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsSparseFilesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsZeroRunsKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsZeroRunsKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsZeroRunsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsCaseSensitiveNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsCaseSensitiveNamesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsCaseSensitiveNamesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsCasePreservedNamesKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLVolumeSupportsCasePreservedNamesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsCasePreservedNamesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsRootDirectoryDatesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeSupportsRootDirectoryDatesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsRootDirectoryDatesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsVolumeSizesKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeSupportsVolumeSizesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsVolumeSizesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsRenamingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeSupportsRenamingKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsRenamingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsAdvisoryFileLockingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeSupportsAdvisoryFileLockingKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsAdvisoryFileLockingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsExtendedSecurityKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeSupportsExtendedSecurityKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsExtendedSecurityKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsBrowsableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsBrowsableKey", "__Internal")]
		unsafe int* NSURLVolumeIsBrowsableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeMaximumFileSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeMaximumFileSizeKey", "__Internal")]
		unsafe int* NSURLVolumeMaximumFileSizeKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsEjectableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsEjectableKey", "__Internal")]
		unsafe int* NSURLVolumeIsEjectableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsRemovableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsRemovableKey", "__Internal")]
		unsafe int* NSURLVolumeIsRemovableKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsInternalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsInternalKey", "__Internal")]
		unsafe int* NSURLVolumeIsInternalKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsAutomountedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsAutomountedKey", "__Internal")]
		unsafe int* NSURLVolumeIsAutomountedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsLocalKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsLocalKey", "__Internal")]
		unsafe int* NSURLVolumeIsLocalKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsReadOnlyKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeIsReadOnlyKey", "__Internal")]
		unsafe int* NSURLVolumeIsReadOnlyKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeCreationDateKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeCreationDateKey", "__Internal")]
		unsafe int* NSURLVolumeCreationDateKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeURLForRemountingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeURLForRemountingKey", "__Internal")]
		unsafe int* NSURLVolumeURLForRemountingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeUUIDStringKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeUUIDStringKey", "__Internal")]
		unsafe int* NSURLVolumeUUIDStringKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeNameKey", "__Internal")]
		unsafe int* NSURLVolumeNameKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeLocalizedNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLVolumeLocalizedNameKey", "__Internal")]
		unsafe int* NSURLVolumeLocalizedNameKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsEncryptedKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeIsEncryptedKey", "__Internal")]
		unsafe int* NSURLVolumeIsEncryptedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeIsRootFileSystemKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeIsRootFileSystemKey", "__Internal")]
		unsafe int* NSURLVolumeIsRootFileSystemKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsCompressionKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeSupportsCompressionKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsCompressionKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsFileCloningKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeSupportsFileCloningKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsFileCloningKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsSwapRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeSupportsSwapRenamingKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsSwapRenamingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsExclusiveRenamingKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLVolumeSupportsExclusiveRenamingKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsExclusiveRenamingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsImmutableFilesKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("NSURLVolumeSupportsImmutableFilesKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsImmutableFilesKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeSupportsAccessPermissionsKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0))) __attribute__((availability(tvos, introduced=11.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("NSURLVolumeSupportsAccessPermissionsKey", "__Internal")]
		unsafe int* NSURLVolumeSupportsAccessPermissionsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeAvailableCapacityForImportantUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("NSURLVolumeAvailableCapacityForImportantUsageKey", "__Internal")]
		unsafe int* NSURLVolumeAvailableCapacityForImportantUsageKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLVolumeAvailableCapacityForOpportunisticUsageKey __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 13), iOS (11, 0)]
		[Field ("NSURLVolumeAvailableCapacityForOpportunisticUsageKey", "__Internal")]
		unsafe int* NSURLVolumeAvailableCapacityForOpportunisticUsageKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLIsUbiquitousItemKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLIsUbiquitousItemKey", "__Internal")]
		unsafe int* NSURLIsUbiquitousItemKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemHasUnresolvedConflictsKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLUbiquitousItemHasUnresolvedConflictsKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemHasUnresolvedConflictsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemIsDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.9))) __attribute__((availability(ios, introduced=5.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSURLUbiquitousItemDownloadingStatusKey instead")]
		[Field ("NSURLUbiquitousItemIsDownloadedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemIsDownloadedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemIsDownloadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLUbiquitousItemIsDownloadingKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemIsDownloadingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemIsUploadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLUbiquitousItemIsUploadedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemIsUploadedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemIsUploadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSURLUbiquitousItemIsUploadingKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemIsUploadingKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemPercentDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemPercentDownloadedKey instead")]
		[Field ("NSURLUbiquitousItemPercentDownloadedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemPercentDownloadedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemPercentUploadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.8))) __attribute__((availability(ios, introduced=5.0, deprecated=6.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 8, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Deprecated (PlatformName.iOS, 6, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemPercentUploadedKey instead")]
		[Field ("NSURLUbiquitousItemPercentUploadedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemPercentUploadedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemDownloadingStatusKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemDownloadingStatusKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadingStatusKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemDownloadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemDownloadingErrorKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadingErrorKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemUploadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemUploadingErrorKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemUploadingErrorKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemDownloadRequestedKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLUbiquitousItemDownloadRequestedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadRequestedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemContainerDisplayNameKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLUbiquitousItemContainerDisplayNameKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemContainerDisplayNameKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousItemIsSharedKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousItemIsSharedKey", "__Internal")]
		unsafe int* NSURLUbiquitousItemIsSharedKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousSharedItemCurrentUserRoleKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemCurrentUserRoleKey", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemCurrentUserRoleKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousSharedItemCurrentUserPermissionsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemCurrentUserPermissionsKey", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemCurrentUserPermissionsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousSharedItemOwnerNameComponentsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemOwnerNameComponentsKey", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemOwnerNameComponentsKey { get; }

		// extern const NSURLResourceKey _Nonnull NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemMostRecentEditorNameComponentsKey { get; }

		// extern const NSURLUbiquitousItemDownloadingStatus _Nonnull NSURLUbiquitousItemDownloadingStatusNotDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemDownloadingStatusNotDownloaded", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadingStatusNotDownloaded { get; }

		// extern const NSURLUbiquitousItemDownloadingStatus _Nonnull NSURLUbiquitousItemDownloadingStatusDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemDownloadingStatusDownloaded", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadingStatusDownloaded { get; }

		// extern const NSURLUbiquitousItemDownloadingStatus _Nonnull NSURLUbiquitousItemDownloadingStatusCurrent __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLUbiquitousItemDownloadingStatusCurrent", "__Internal")]
		unsafe int* NSURLUbiquitousItemDownloadingStatusCurrent { get; }

		// extern const NSURLUbiquitousSharedItemRole _Nonnull NSURLUbiquitousSharedItemRoleOwner __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemRoleOwner", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemRoleOwner { get; }

		// extern const NSURLUbiquitousSharedItemRole _Nonnull NSURLUbiquitousSharedItemRoleParticipant __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemRoleParticipant", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemRoleParticipant { get; }

		// extern const NSURLUbiquitousSharedItemPermissions _Nonnull NSURLUbiquitousSharedItemPermissionsReadOnly __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemPermissionsReadOnly", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemPermissionsReadOnly { get; }

		// extern const NSURLUbiquitousSharedItemPermissions _Nonnull NSURLUbiquitousSharedItemPermissionsReadWrite __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSURLUbiquitousSharedItemPermissionsReadWrite", "__Internal")]
		unsafe int* NSURLUbiquitousSharedItemPermissionsReadWrite { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int *const _Nonnull NSFileManagerUnmountDissentingProcessIdentifierErrorKey __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 11)]
		[Field ("NSFileManagerUnmountDissentingProcessIdentifierErrorKey", "__Internal")]
		unsafe int* NSFileManagerUnmountDissentingProcessIdentifierErrorKey { get; }

		// extern const NSNotificationName _Nonnull NSUbiquityIdentityDidChangeNotification __attribute__((availability(macos, introduced=10.8))) __attribute__((availability(ios, introduced=6.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 8), iOS (6, 0)]
		[Field ("NSUbiquityIdentityDidChangeNotification", "__Internal")]
		unsafe int* NSUbiquityIdentityDidChangeNotification { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeDirectory;
		[Field ("NSFileTypeDirectory", "__Internal")]
		unsafe int* NSFileTypeDirectory { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeRegular;
		[Field ("NSFileTypeRegular", "__Internal")]
		unsafe int* NSFileTypeRegular { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeSymbolicLink;
		[Field ("NSFileTypeSymbolicLink", "__Internal")]
		unsafe int* NSFileTypeSymbolicLink { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeSocket;
		[Field ("NSFileTypeSocket", "__Internal")]
		unsafe int* NSFileTypeSocket { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeCharacterSpecial;
		[Field ("NSFileTypeCharacterSpecial", "__Internal")]
		unsafe int* NSFileTypeCharacterSpecial { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeBlockSpecial;
		[Field ("NSFileTypeBlockSpecial", "__Internal")]
		unsafe int* NSFileTypeBlockSpecial { get; }

		// extern const NSFileAttributeType _Nonnull NSFileTypeUnknown;
		[Field ("NSFileTypeUnknown", "__Internal")]
		unsafe int* NSFileTypeUnknown { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSize;
		[Field ("NSFileSize", "__Internal")]
		unsafe int* NSFileSize { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileModificationDate;
		[Field ("NSFileModificationDate", "__Internal")]
		unsafe int* NSFileModificationDate { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileReferenceCount;
		[Field ("NSFileReferenceCount", "__Internal")]
		unsafe int* NSFileReferenceCount { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileDeviceIdentifier;
		[Field ("NSFileDeviceIdentifier", "__Internal")]
		unsafe int* NSFileDeviceIdentifier { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileOwnerAccountName;
		[Field ("NSFileOwnerAccountName", "__Internal")]
		unsafe int* NSFileOwnerAccountName { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileGroupOwnerAccountName;
		[Field ("NSFileGroupOwnerAccountName", "__Internal")]
		unsafe int* NSFileGroupOwnerAccountName { get; }

		// extern const NSFileAttributeKey _Nonnull NSFilePosixPermissions;
		[Field ("NSFilePosixPermissions", "__Internal")]
		unsafe int* NSFilePosixPermissions { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemNumber;
		[Field ("NSFileSystemNumber", "__Internal")]
		unsafe int* NSFileSystemNumber { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemFileNumber;
		[Field ("NSFileSystemFileNumber", "__Internal")]
		unsafe int* NSFileSystemFileNumber { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileExtensionHidden;
		[Field ("NSFileExtensionHidden", "__Internal")]
		unsafe int* NSFileExtensionHidden { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileHFSCreatorCode;
		[Field ("NSFileHFSCreatorCode", "__Internal")]
		unsafe int* NSFileHFSCreatorCode { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileHFSTypeCode;
		[Field ("NSFileHFSTypeCode", "__Internal")]
		unsafe int* NSFileHFSTypeCode { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileImmutable;
		[Field ("NSFileImmutable", "__Internal")]
		unsafe int* NSFileImmutable { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileAppendOnly;
		[Field ("NSFileAppendOnly", "__Internal")]
		unsafe int* NSFileAppendOnly { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileCreationDate;
		[Field ("NSFileCreationDate", "__Internal")]
		unsafe int* NSFileCreationDate { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileOwnerAccountID;
		[Field ("NSFileOwnerAccountID", "__Internal")]
		unsafe int* NSFileOwnerAccountID { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileGroupOwnerAccountID;
		[Field ("NSFileGroupOwnerAccountID", "__Internal")]
		unsafe int* NSFileGroupOwnerAccountID { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileBusy;
		[Field ("NSFileBusy", "__Internal")]
		unsafe int* NSFileBusy { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileProtectionKey __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (4, 0)]
		[Field ("NSFileProtectionKey", "__Internal")]
		unsafe int* NSFileProtectionKey { get; }

		// extern const NSFileProtectionType _Nonnull NSFileProtectionNone __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (4, 0)]
		[Field ("NSFileProtectionNone", "__Internal")]
		unsafe int* NSFileProtectionNone { get; }

		// extern const NSFileProtectionType _Nonnull NSFileProtectionComplete __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (4, 0)]
		[Field ("NSFileProtectionComplete", "__Internal")]
		unsafe int* NSFileProtectionComplete { get; }

		// extern const NSFileProtectionType _Nonnull NSFileProtectionCompleteUnlessOpen __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (5, 0)]
		[Field ("NSFileProtectionCompleteUnlessOpen", "__Internal")]
		unsafe int* NSFileProtectionCompleteUnlessOpen { get; }

		// extern const NSFileProtectionType _Nonnull NSFileProtectionCompleteUntilFirstUserAuthentication __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (5, 0)]
		[Field ("NSFileProtectionCompleteUntilFirstUserAuthentication", "__Internal")]
		unsafe int* NSFileProtectionCompleteUntilFirstUserAuthentication { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemSize;
		[Field ("NSFileSystemSize", "__Internal")]
		unsafe int* NSFileSystemSize { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemFreeSize;
		[Field ("NSFileSystemFreeSize", "__Internal")]
		unsafe int* NSFileSystemFreeSize { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemNodes;
		[Field ("NSFileSystemNodes", "__Internal")]
		unsafe int* NSFileSystemNodes { get; }

		// extern const NSFileAttributeKey _Nonnull NSFileSystemFreeNodes;
		[Field ("NSFileSystemFreeNodes", "__Internal")]
		unsafe int* NSFileSystemFreeNodes { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int OSType;
		[Field ("OSType", "__Internal")]
		int OSType { get; }

		// extern int OSType;
		[Field ("OSType", "__Internal")]
		int OSType { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSPointerFunctions;
		[Field ("NSPointerFunctions", "__Internal")]
		int NSPointerFunctions { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSHashTable;
		[Field ("NSHashTable", "__Internal")]
		int NSHashTable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSHashTable;
		[Field ("NSHashTable", "__Internal")]
		int NSHashTable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSHashEnumerator;
		[Field ("NSHashEnumerator", "__Internal")]
		int NSHashEnumerator { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSHashTableCallBacks NSIntegerHashCallBacks __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 5)]
		[Field ("NSIntegerHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSIntegerHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSNonOwnedPointerHashCallBacks;
		[Field ("NSNonOwnedPointerHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSNonOwnedPointerHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSNonRetainedObjectHashCallBacks;
		[Field ("NSNonRetainedObjectHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSNonRetainedObjectHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSObjectHashCallBacks;
		[Field ("NSObjectHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSObjectHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSOwnedObjectIdentityHashCallBacks;
		[Field ("NSOwnedObjectIdentityHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSOwnedObjectIdentityHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSOwnedPointerHashCallBacks;
		[Field ("NSOwnedPointerHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSOwnedPointerHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSPointerToStructHashCallBacks;
		[Field ("NSPointerToStructHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSPointerToStructHashCallBacks { get; }

		// extern const NSHashTableCallBacks NSIntHashCallBacks __attribute__((availability(macos, introduced=10.0, deprecated=10.5))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 5, message: "Not supported")]
		[NoWatch, NoTV, NoiOS]
		[Field ("NSIntHashCallBacks", "__Internal")]
		NSHashTableCallBacks NSIntHashCallBacks { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieName;
		[Field ("NSHTTPCookieName", "__Internal")]
		unsafe int* NSHTTPCookieName { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieValue;
		[Field ("NSHTTPCookieValue", "__Internal")]
		unsafe int* NSHTTPCookieValue { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieOriginURL;
		[Field ("NSHTTPCookieOriginURL", "__Internal")]
		unsafe int* NSHTTPCookieOriginURL { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieVersion;
		[Field ("NSHTTPCookieVersion", "__Internal")]
		unsafe int* NSHTTPCookieVersion { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieDomain;
		[Field ("NSHTTPCookieDomain", "__Internal")]
		unsafe int* NSHTTPCookieDomain { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookiePath;
		[Field ("NSHTTPCookiePath", "__Internal")]
		unsafe int* NSHTTPCookiePath { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieSecure;
		[Field ("NSHTTPCookieSecure", "__Internal")]
		unsafe int* NSHTTPCookieSecure { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieExpires;
		[Field ("NSHTTPCookieExpires", "__Internal")]
		unsafe int* NSHTTPCookieExpires { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieComment;
		[Field ("NSHTTPCookieComment", "__Internal")]
		unsafe int* NSHTTPCookieComment { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieCommentURL;
		[Field ("NSHTTPCookieCommentURL", "__Internal")]
		unsafe int* NSHTTPCookieCommentURL { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieDiscard;
		[Field ("NSHTTPCookieDiscard", "__Internal")]
		unsafe int* NSHTTPCookieDiscard { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieMaximumAge;
		[Field ("NSHTTPCookieMaximumAge", "__Internal")]
		unsafe int* NSHTTPCookieMaximumAge { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookiePort;
		[Field ("NSHTTPCookiePort", "__Internal")]
		unsafe int* NSHTTPCookiePort { get; }

		// extern const NSHTTPCookiePropertyKey _Nonnull NSHTTPCookieSameSitePolicy __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("NSHTTPCookieSameSitePolicy", "__Internal")]
		unsafe int* NSHTTPCookieSameSitePolicy { get; }

		// extern const NSHTTPCookieStringPolicy _Nonnull NSHTTPCookieSameSiteLax __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("NSHTTPCookieSameSiteLax", "__Internal")]
		unsafe int* NSHTTPCookieSameSiteLax { get; }

		// extern const NSHTTPCookieStringPolicy _Nonnull NSHTTPCookieSameSiteStrict __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("NSHTTPCookieSameSiteStrict", "__Internal")]
		unsafe int* NSHTTPCookieSameSiteStrict { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSHTTPCookieStorage;
		[Field ("NSHTTPCookieStorage", "__Internal")]
		int NSHTTPCookieStorage { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern const NSNotificationName _Nonnull NSHTTPCookieManagerCookiesChangedNotification;
		[Field ("NSHTTPCookieManagerCookiesChangedNotification", "__Internal")]
		unsafe int* NSHTTPCookieManagerCookiesChangedNotification { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSIndexPath;
		[Field ("NSIndexPath", "__Internal")]
		int NSIndexPath { get; }

		// extern int NSIndexPath;
		[Field ("NSIndexPath", "__Internal")]
		int NSIndexPath { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int ObjectType;
		[Field ("ObjectType", "__Internal")]
		int ObjectType { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int ObjectType;
		[Field ("ObjectType", "__Internal")]
		int ObjectType { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSIndexSet;
		[Field ("NSIndexSet", "__Internal")]
		int NSIndexSet { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSOrderedCollectionDifference;
		[Field ("NSOrderedCollectionDifference", "__Internal")]
		int NSOrderedCollectionDifference { get; }

		// extern int NSOrderedCollectionDifference;
		[Field ("NSOrderedCollectionDifference", "__Internal")]
		int NSOrderedCollectionDifference { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSExceptionName _Nonnull NSUndefinedKeyException;
		[Field ("NSUndefinedKeyException", "__Internal")]
		unsafe int* NSUndefinedKeyException { get; }

		// extern const NSKeyValueOperator _Nonnull NSAverageKeyValueOperator;
		[Field ("NSAverageKeyValueOperator", "__Internal")]
		unsafe int* NSAverageKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSCountKeyValueOperator;
		[Field ("NSCountKeyValueOperator", "__Internal")]
		unsafe int* NSCountKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSDistinctUnionOfArraysKeyValueOperator;
		[Field ("NSDistinctUnionOfArraysKeyValueOperator", "__Internal")]
		unsafe int* NSDistinctUnionOfArraysKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSDistinctUnionOfObjectsKeyValueOperator;
		[Field ("NSDistinctUnionOfObjectsKeyValueOperator", "__Internal")]
		unsafe int* NSDistinctUnionOfObjectsKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSDistinctUnionOfSetsKeyValueOperator;
		[Field ("NSDistinctUnionOfSetsKeyValueOperator", "__Internal")]
		unsafe int* NSDistinctUnionOfSetsKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSMaximumKeyValueOperator;
		[Field ("NSMaximumKeyValueOperator", "__Internal")]
		unsafe int* NSMaximumKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSMinimumKeyValueOperator;
		[Field ("NSMinimumKeyValueOperator", "__Internal")]
		unsafe int* NSMinimumKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSSumKeyValueOperator;
		[Field ("NSSumKeyValueOperator", "__Internal")]
		unsafe int* NSSumKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSUnionOfArraysKeyValueOperator;
		[Field ("NSUnionOfArraysKeyValueOperator", "__Internal")]
		unsafe int* NSUnionOfArraysKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSUnionOfObjectsKeyValueOperator;
		[Field ("NSUnionOfObjectsKeyValueOperator", "__Internal")]
		unsafe int* NSUnionOfObjectsKeyValueOperator { get; }

		// extern const NSKeyValueOperator _Nonnull NSUnionOfSetsKeyValueOperator;
		[Field ("NSUnionOfSetsKeyValueOperator", "__Internal")]
		unsafe int* NSUnionOfSetsKeyValueOperator { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSMutableArray;
		[Field ("NSMutableArray", "__Internal")]
		int NSMutableArray { get; }

		// extern int NSMutableOrderedSet;
		[Field ("NSMutableOrderedSet", "__Internal")]
		int NSMutableOrderedSet { get; }

		// extern int NSMutableSet;
		[Field ("NSMutableSet", "__Internal")]
		int NSMutableSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSMutableArray;
		[Field ("NSMutableArray", "__Internal")]
		int NSMutableArray { get; }

		// extern int NSMutableOrderedSet;
		[Field ("NSMutableOrderedSet", "__Internal")]
		int NSMutableOrderedSet { get; }

		// extern int NSMutableSet;
		[Field ("NSMutableSet", "__Internal")]
		int NSMutableSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSKeyValueChangeKey _Nonnull NSKeyValueChangeKindKey;
		[Field ("NSKeyValueChangeKindKey", "__Internal")]
		unsafe int* NSKeyValueChangeKindKey { get; }

		// extern const NSKeyValueChangeKey _Nonnull NSKeyValueChangeNewKey;
		[Field ("NSKeyValueChangeNewKey", "__Internal")]
		unsafe int* NSKeyValueChangeNewKey { get; }

		// extern const NSKeyValueChangeKey _Nonnull NSKeyValueChangeOldKey;
		[Field ("NSKeyValueChangeOldKey", "__Internal")]
		unsafe int* NSKeyValueChangeOldKey { get; }

		// extern const NSKeyValueChangeKey _Nonnull NSKeyValueChangeIndexesKey;
		[Field ("NSKeyValueChangeIndexesKey", "__Internal")]
		unsafe int* NSKeyValueChangeIndexesKey { get; }

		// extern const NSKeyValueChangeKey _Nonnull NSKeyValueChangeNotificationIsPriorKey __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSKeyValueChangeNotificationIsPriorKey", "__Internal")]
		unsafe int* NSKeyValueChangeNotificationIsPriorKey { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern const NSExceptionName _Nonnull NSInvalidArchiveOperationException;
		[Field ("NSInvalidArchiveOperationException", "__Internal")]
		unsafe int* NSInvalidArchiveOperationException { get; }

		// extern const NSExceptionName _Nonnull NSInvalidUnarchiveOperationException;
		[Field ("NSInvalidUnarchiveOperationException", "__Internal")]
		unsafe int* NSInvalidUnarchiveOperationException { get; }

		// extern int *const _Nonnull NSKeyedArchiveRootObjectKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSKeyedArchiveRootObjectKey", "__Internal")]
		unsafe int* NSKeyedArchiveRootObjectKey { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSData;
		[Field ("NSData", "__Internal")]
		int NSData { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int int32_t;
		[Field ("int32_t", "__Internal")]
		int int32_t { get; }

		// extern int int64_t;
		[Field ("int64_t", "__Internal")]
		int int64_t { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSMapTable;
		[Field ("NSMapTable", "__Internal")]
		int NSMapTable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSMapTable;
		[Field ("NSMapTable", "__Internal")]
		int NSMapTable { get; }

		// extern int NSMapTable;
		[Field ("NSMapTable", "__Internal")]
		int NSMapTable { get; }

		// extern int NSMapTable;
		[Field ("NSMapTable", "__Internal")]
		int NSMapTable { get; }

		// extern int NSMapTable;
		[Field ("NSMapTable", "__Internal")]
		int NSMapTable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSEnumerator;
		[Field ("NSEnumerator", "__Internal")]
		int NSEnumerator { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSMapEnumerator;
		[Field ("NSMapEnumerator", "__Internal")]
		int NSMapEnumerator { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSMapTableKeyCallBacks NSIntegerMapKeyCallBacks __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 5)]
		[Field ("NSIntegerMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSIntegerMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSNonOwnedPointerMapKeyCallBacks;
		[Field ("NSNonOwnedPointerMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSNonOwnedPointerMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSNonOwnedPointerOrNullMapKeyCallBacks;
		[Field ("NSNonOwnedPointerOrNullMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSNonOwnedPointerOrNullMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSNonRetainedObjectMapKeyCallBacks;
		[Field ("NSNonRetainedObjectMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSNonRetainedObjectMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSObjectMapKeyCallBacks;
		[Field ("NSObjectMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSObjectMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSOwnedPointerMapKeyCallBacks;
		[Field ("NSOwnedPointerMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSOwnedPointerMapKeyCallBacks { get; }

		// extern const NSMapTableKeyCallBacks NSIntMapKeyCallBacks __attribute__((availability(macos, introduced=10.0, deprecated=10.5))) __attribute__((availability(ios, introduced=2.0, deprecated=2.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 5, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Field ("NSIntMapKeyCallBacks", "__Internal")]
		NSMapTableKeyCallBacks NSIntMapKeyCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSIntegerMapValueCallBacks __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 5)]
		[Field ("NSIntegerMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSIntegerMapValueCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSNonOwnedPointerMapValueCallBacks;
		[Field ("NSNonOwnedPointerMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSNonOwnedPointerMapValueCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSObjectMapValueCallBacks;
		[Field ("NSObjectMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSObjectMapValueCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSNonRetainedObjectMapValueCallBacks;
		[Field ("NSNonRetainedObjectMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSNonRetainedObjectMapValueCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSOwnedPointerMapValueCallBacks;
		[Field ("NSOwnedPointerMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSOwnedPointerMapValueCallBacks { get; }

		// extern const NSMapTableValueCallBacks NSIntMapValueCallBacks __attribute__((availability(macos, introduced=10.0, deprecated=10.5))) __attribute__((availability(ios, introduced=2.0, deprecated=2.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Not supported")]
		[Deprecated (PlatformName.MacOSX, 10, 5, message: "Not supported")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.iOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Not supported")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Not supported")]
		[Field ("NSIntMapValueCallBacks", "__Internal")]
		NSMapTableValueCallBacks NSIntMapValueCallBacks { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSExceptionName _Nonnull NSInvocationOperationCancelledException __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSInvocationOperationCancelledException", "__Internal")]
		unsafe int* NSInvocationOperationCancelledException { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSPointerArray;
		[Field ("NSPointerArray", "__Internal")]
		int NSPointerArray { get; }

		// extern int NSPointerArray;
		[Field ("NSPointerArray", "__Internal")]
		int NSPointerArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSPointerArray;
		[Field ("NSPointerArray", "__Internal")]
		int NSPointerArray { get; }

		// extern const NSNotificationName _Nonnull NSPortDidBecomeInvalidNotification;
		[Field ("NSPortDidBecomeInvalidNotification", "__Internal")]
		unsafe int* NSPortDidBecomeInvalidNotification { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSPort;
		[Field ("NSPort", "__Internal")]
		int NSPort { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSPort;
		[Field ("NSPort", "__Internal")]
		int NSPort { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSNotificationName _Nonnull NSProcessInfoPowerStateDidChangeNotification __attribute__((availability(ios, introduced=9.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 0)]
		[Field ("NSProcessInfoPowerStateDidChangeNotification", "__Internal")]
		unsafe int* NSProcessInfoPowerStateDidChangeNotification { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int Class;
		[Field ("Class", "__Internal")]
		int Class { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingJobTitleKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingJobTitleKey", "__Internal")]
		unsafe int* NSTextCheckingJobTitleKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingOrganizationKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingOrganizationKey", "__Internal")]
		unsafe int* NSTextCheckingOrganizationKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingStreetKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingStreetKey", "__Internal")]
		unsafe int* NSTextCheckingStreetKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingCityKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingCityKey", "__Internal")]
		unsafe int* NSTextCheckingCityKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingStateKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingStateKey", "__Internal")]
		unsafe int* NSTextCheckingStateKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingZIPKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingZIPKey", "__Internal")]
		unsafe int* NSTextCheckingZIPKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingCountryKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingCountryKey", "__Internal")]
		unsafe int* NSTextCheckingCountryKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingPhoneKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSTextCheckingPhoneKey", "__Internal")]
		unsafe int* NSTextCheckingPhoneKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingAirlineKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("NSTextCheckingAirlineKey", "__Internal")]
		unsafe int* NSTextCheckingAirlineKey { get; }

		// extern const NSTextCheckingKey _Nonnull NSTextCheckingFlightKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("NSTextCheckingFlightKey", "__Internal")]
		unsafe int* NSTextCheckingFlightKey { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }

		// extern int NSTextCheckingResult;
		[Field ("NSTextCheckingResult", "__Internal")]
		int NSTextCheckingResult { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSComparisonResult;
		[Field ("NSComparisonResult", "__Internal")]
		int NSComparisonResult { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern const NSStreamSocketSecurityLevel _Nonnull NSStreamSocketSecurityLevelNone __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSecurityLevelNone", "__Internal")]
		unsafe int* NSStreamSocketSecurityLevelNone { get; }

		// extern const NSStreamSocketSecurityLevel _Nonnull NSStreamSocketSecurityLevelSSLv2 __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSecurityLevelSSLv2", "__Internal")]
		unsafe int* NSStreamSocketSecurityLevelSSLv2 { get; }

		// extern const NSStreamSocketSecurityLevel _Nonnull NSStreamSocketSecurityLevelSSLv3 __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSecurityLevelSSLv3", "__Internal")]
		unsafe int* NSStreamSocketSecurityLevelSSLv3 { get; }

		// extern const NSStreamSocketSecurityLevel _Nonnull NSStreamSocketSecurityLevelTLSv1 __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSecurityLevelTLSv1", "__Internal")]
		unsafe int* NSStreamSocketSecurityLevelTLSv1 { get; }

		// extern const NSStreamSocketSecurityLevel _Nonnull NSStreamSocketSecurityLevelNegotiatedSSL __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSecurityLevelNegotiatedSSL", "__Internal")]
		unsafe int* NSStreamSocketSecurityLevelNegotiatedSSL { get; }

		// extern const NSStreamPropertyKey _Nonnull NSStreamSOCKSProxyConfigurationKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyConfigurationKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyConfigurationKey { get; }

		// extern const NSStreamSOCKSProxyConfiguration _Nonnull NSStreamSOCKSProxyHostKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyHostKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyHostKey { get; }

		// extern const NSStreamSOCKSProxyConfiguration _Nonnull NSStreamSOCKSProxyPortKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyPortKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyPortKey { get; }

		// extern const NSStreamSOCKSProxyConfiguration _Nonnull NSStreamSOCKSProxyVersionKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyVersionKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyVersionKey { get; }

		// extern const NSStreamSOCKSProxyConfiguration _Nonnull NSStreamSOCKSProxyUserKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyUserKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyUserKey { get; }

		// extern const NSStreamSOCKSProxyConfiguration _Nonnull NSStreamSOCKSProxyPasswordKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyPasswordKey", "__Internal")]
		unsafe int* NSStreamSOCKSProxyPasswordKey { get; }

		// extern const NSStreamSOCKSProxyVersion _Nonnull NSStreamSOCKSProxyVersion4 __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyVersion4", "__Internal")]
		unsafe int* NSStreamSOCKSProxyVersion4 { get; }

		// extern const NSStreamSOCKSProxyVersion _Nonnull NSStreamSOCKSProxyVersion5 __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSProxyVersion5", "__Internal")]
		unsafe int* NSStreamSOCKSProxyVersion5 { get; }

		// extern const NSStreamPropertyKey _Nonnull NSStreamDataWrittenToMemoryStreamKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamDataWrittenToMemoryStreamKey", "__Internal")]
		unsafe int* NSStreamDataWrittenToMemoryStreamKey { get; }

		// extern const NSStreamPropertyKey _Nonnull NSStreamFileCurrentOffsetKey __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamFileCurrentOffsetKey", "__Internal")]
		unsafe int* NSStreamFileCurrentOffsetKey { get; }

		// extern const NSErrorDomain _Nonnull NSStreamSocketSSLErrorDomain __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSocketSSLErrorDomain", "__Internal")]
		unsafe int* NSStreamSocketSSLErrorDomain { get; }

		// extern const NSErrorDomain _Nonnull NSStreamSOCKSErrorDomain __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (2, 0)]
		[Field ("NSStreamSOCKSErrorDomain", "__Internal")]
		unsafe int* NSStreamSOCKSErrorDomain { get; }

		// extern const NSStreamPropertyKey _Nonnull NSStreamNetworkServiceType __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("NSStreamNetworkServiceType", "__Internal")]
		unsafe int* NSStreamNetworkServiceType { get; }

		// extern const NSStreamNetworkServiceTypeValue _Nonnull NSStreamNetworkServiceTypeVoIP __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (4, 0)]
		[Field ("NSStreamNetworkServiceTypeVoIP", "__Internal")]
		unsafe int* NSStreamNetworkServiceTypeVoIP { get; }

		// extern const NSStreamNetworkServiceTypeValue _Nonnull NSStreamNetworkServiceTypeVideo __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSStreamNetworkServiceTypeVideo", "__Internal")]
		unsafe int* NSStreamNetworkServiceTypeVideo { get; }

		// extern const NSStreamNetworkServiceTypeValue _Nonnull NSStreamNetworkServiceTypeBackground __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSStreamNetworkServiceTypeBackground", "__Internal")]
		unsafe int* NSStreamNetworkServiceTypeBackground { get; }

		// extern const NSStreamNetworkServiceTypeValue _Nonnull NSStreamNetworkServiceTypeVoice __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSStreamNetworkServiceTypeVoice", "__Internal")]
		unsafe int* NSStreamNetworkServiceTypeVoice { get; }

		// extern const NSStreamNetworkServiceTypeValue _Nonnull NSStreamNetworkServiceTypeCallSignaling __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("NSStreamNetworkServiceTypeCallSignaling", "__Internal")]
		unsafe int* NSStreamNetworkServiceTypeCallSignaling { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSNotificationName _Nonnull NSDidBecomeSingleThreadedNotification;
		[Field ("NSDidBecomeSingleThreadedNotification", "__Internal")]
		unsafe int* NSDidBecomeSingleThreadedNotification { get; }

		// extern const NSNotificationName _Nonnull NSThreadWillExitNotification;
		[Field ("NSThreadWillExitNotification", "__Internal")]
		unsafe int* NSThreadWillExitNotification { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSTimeInterval;
		[Field ("NSTimeInterval", "__Internal")]
		int NSTimeInterval { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSTimer;
		[Field ("NSTimer", "__Internal")]
		int NSTimer { get; }

		// extern int NSTimer;
		[Field ("NSTimer", "__Internal")]
		int NSTimer { get; }

		// extern int NSTimer;
		[Field ("NSTimer", "__Internal")]
		int NSTimer { get; }

		// extern int NSTimer;
		[Field ("NSTimer", "__Internal")]
		int NSTimer { get; }

		// extern int NSTimer;
		[Field ("NSTimer", "__Internal")]
		int NSTimer { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSecClass __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecClass", "__Internal")]
		unsafe CFStringRef* kSecClass { get; }

		// extern const CFStringRef _Nonnull kSecClassInternetPassword __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecClassInternetPassword", "__Internal")]
		unsafe CFStringRef* kSecClassInternetPassword { get; }

		// extern const CFStringRef _Nonnull kSecClassGenericPassword __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecClassGenericPassword", "__Internal")]
		unsafe CFStringRef* kSecClassGenericPassword { get; }

		// extern const CFStringRef _Nonnull kSecClassCertificate __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecClassCertificate", "__Internal")]
		unsafe CFStringRef* kSecClassCertificate { get; }

		// extern const CFStringRef _Nonnull kSecClassKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecClassKey", "__Internal")]
		unsafe CFStringRef* kSecClassKey { get; }

		// extern const CFStringRef _Nonnull kSecClassIdentity __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecClassIdentity", "__Internal")]
		unsafe CFStringRef* kSecClassIdentity { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessible __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrAccessible", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessible { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccess __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrAccess", "__Internal")]
		unsafe CFStringRef* kSecAttrAccess { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessControl __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0)));
		[Mac (10, 10), iOS (8, 0)]
		[Field ("kSecAttrAccessControl", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessControl { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessGroup __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=3.0)));
		[Mac (10, 9), iOS (3, 0)]
		[Field ("kSecAttrAccessGroup", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessGroup { get; }

		// extern const CFStringRef _Nonnull kSecAttrSynchronizable __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10, 9), iOS (7, 0)]
		[Field ("kSecAttrSynchronizable", "__Internal")]
		unsafe CFStringRef* kSecAttrSynchronizable { get; }

		// extern const CFStringRef _Nonnull kSecAttrSynchronizableAny __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0)));
		[Mac (10, 9), iOS (7, 0)]
		[Field ("kSecAttrSynchronizableAny", "__Internal")]
		unsafe CFStringRef* kSecAttrSynchronizableAny { get; }

		// extern const CFStringRef _Nonnull kSecAttrCreationDate __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCreationDate", "__Internal")]
		unsafe CFStringRef* kSecAttrCreationDate { get; }

		// extern const CFStringRef _Nonnull kSecAttrModificationDate __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrModificationDate", "__Internal")]
		unsafe CFStringRef* kSecAttrModificationDate { get; }

		// extern const CFStringRef _Nonnull kSecAttrDescription __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrDescription", "__Internal")]
		unsafe CFStringRef* kSecAttrDescription { get; }

		// extern const CFStringRef _Nonnull kSecAttrComment __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrComment", "__Internal")]
		unsafe CFStringRef* kSecAttrComment { get; }

		// extern const CFStringRef _Nonnull kSecAttrCreator __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCreator", "__Internal")]
		unsafe CFStringRef* kSecAttrCreator { get; }

		// extern const CFStringRef _Nonnull kSecAttrType __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrType", "__Internal")]
		unsafe CFStringRef* kSecAttrType { get; }

		// extern const CFStringRef _Nonnull kSecAttrLabel __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrLabel", "__Internal")]
		unsafe CFStringRef* kSecAttrLabel { get; }

		// extern const CFStringRef _Nonnull kSecAttrIsInvisible __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIsInvisible", "__Internal")]
		unsafe CFStringRef* kSecAttrIsInvisible { get; }

		// extern const CFStringRef _Nonnull kSecAttrIsNegative __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIsNegative", "__Internal")]
		unsafe CFStringRef* kSecAttrIsNegative { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccount __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAccount", "__Internal")]
		unsafe CFStringRef* kSecAttrAccount { get; }

		// extern const CFStringRef _Nonnull kSecAttrService __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrService", "__Internal")]
		unsafe CFStringRef* kSecAttrService { get; }

		// extern const CFStringRef _Nonnull kSecAttrGeneric __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrGeneric", "__Internal")]
		unsafe CFStringRef* kSecAttrGeneric { get; }

		// extern const CFStringRef _Nonnull kSecAttrSecurityDomain __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrSecurityDomain", "__Internal")]
		unsafe CFStringRef* kSecAttrSecurityDomain { get; }

		// extern const CFStringRef _Nonnull kSecAttrServer __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrServer", "__Internal")]
		unsafe CFStringRef* kSecAttrServer { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocol __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocol", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocol { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationType __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationType", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationType { get; }

		// extern const CFStringRef _Nonnull kSecAttrPort __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrPort", "__Internal")]
		unsafe CFStringRef* kSecAttrPort { get; }

		// extern const CFStringRef _Nonnull kSecAttrPath __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrPath", "__Internal")]
		unsafe CFStringRef* kSecAttrPath { get; }

		// extern const CFStringRef _Nonnull kSecAttrSubject __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrSubject", "__Internal")]
		unsafe CFStringRef* kSecAttrSubject { get; }

		// extern const CFStringRef _Nonnull kSecAttrIssuer __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIssuer", "__Internal")]
		unsafe CFStringRef* kSecAttrIssuer { get; }

		// extern const CFStringRef _Nonnull kSecAttrSerialNumber __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrSerialNumber", "__Internal")]
		unsafe CFStringRef* kSecAttrSerialNumber { get; }

		// extern const CFStringRef _Nonnull kSecAttrSubjectKeyID __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrSubjectKeyID", "__Internal")]
		unsafe CFStringRef* kSecAttrSubjectKeyID { get; }

		// extern const CFStringRef _Nonnull kSecAttrPublicKeyHash __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrPublicKeyHash", "__Internal")]
		unsafe CFStringRef* kSecAttrPublicKeyHash { get; }

		// extern const CFStringRef _Nonnull kSecAttrCertificateType __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCertificateType", "__Internal")]
		unsafe CFStringRef* kSecAttrCertificateType { get; }

		// extern const CFStringRef _Nonnull kSecAttrCertificateEncoding __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCertificateEncoding", "__Internal")]
		unsafe CFStringRef* kSecAttrCertificateEncoding { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyClass __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrKeyClass", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyClass { get; }

		// extern const CFStringRef _Nonnull kSecAttrApplicationLabel __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrApplicationLabel", "__Internal")]
		unsafe CFStringRef* kSecAttrApplicationLabel { get; }

		// extern const CFStringRef _Nonnull kSecAttrIsPermanent __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIsPermanent", "__Internal")]
		unsafe CFStringRef* kSecAttrIsPermanent { get; }

		// extern const CFStringRef _Nonnull kSecAttrIsSensitive __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIsSensitive", "__Internal")]
		unsafe CFStringRef* kSecAttrIsSensitive { get; }

		// extern const CFStringRef _Nonnull kSecAttrIsExtractable __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrIsExtractable", "__Internal")]
		unsafe CFStringRef* kSecAttrIsExtractable { get; }

		// extern const CFStringRef _Nonnull kSecAttrApplicationTag __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrApplicationTag", "__Internal")]
		unsafe CFStringRef* kSecAttrApplicationTag { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyType __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrKeyType", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyType { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRF __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRF", "__Internal")]
		unsafe CFStringRef* kSecAttrPRF { get; }

		// extern const CFStringRef _Nonnull kSecAttrSalt __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrSalt", "__Internal")]
		unsafe CFStringRef* kSecAttrSalt { get; }

		// extern const CFStringRef _Nonnull kSecAttrRounds __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrRounds", "__Internal")]
		unsafe CFStringRef* kSecAttrRounds { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeySizeInBits __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrKeySizeInBits", "__Internal")]
		unsafe CFStringRef* kSecAttrKeySizeInBits { get; }

		// extern const CFStringRef _Nonnull kSecAttrEffectiveKeySize __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrEffectiveKeySize", "__Internal")]
		unsafe CFStringRef* kSecAttrEffectiveKeySize { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanEncrypt __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanEncrypt", "__Internal")]
		unsafe CFStringRef* kSecAttrCanEncrypt { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanDecrypt __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanDecrypt", "__Internal")]
		unsafe CFStringRef* kSecAttrCanDecrypt { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanDerive __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanDerive", "__Internal")]
		unsafe CFStringRef* kSecAttrCanDerive { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanSign __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanSign", "__Internal")]
		unsafe CFStringRef* kSecAttrCanSign { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanVerify __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanVerify", "__Internal")]
		unsafe CFStringRef* kSecAttrCanVerify { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanWrap __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanWrap", "__Internal")]
		unsafe CFStringRef* kSecAttrCanWrap { get; }

		// extern const CFStringRef _Nonnull kSecAttrCanUnwrap __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrCanUnwrap", "__Internal")]
		unsafe CFStringRef* kSecAttrCanUnwrap { get; }

		// extern const CFStringRef _Nonnull kSecAttrSyncViewHint __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecAttrSyncViewHint", "__Internal")]
		unsafe CFStringRef* kSecAttrSyncViewHint { get; }

		// extern const CFStringRef _Nonnull kSecAttrTokenID __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 12), iOS (9, 0)]
		[Field ("kSecAttrTokenID", "__Internal")]
		unsafe CFStringRef* kSecAttrTokenID { get; }

		// extern const CFStringRef _Nonnull kSecAttrPersistantReference __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecAttrPersistantReference", "__Internal")]
		unsafe CFStringRef* kSecAttrPersistantReference { get; }

		// extern const CFStringRef _Nonnull kSecAttrPersistentReference __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecAttrPersistentReference", "__Internal")]
		unsafe CFStringRef* kSecAttrPersistentReference { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleWhenUnlocked __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrAccessibleWhenUnlocked", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleWhenUnlocked { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleAfterFirstUnlock __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrAccessibleAfterFirstUnlock", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleAfterFirstUnlock { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleAlways __attribute__((availability(macos, introduced=10.9, deprecated=10.14))) __attribute__((availability(ios, introduced=4.0, deprecated=12.0)));
		[Introduced (PlatformName.MacOSX, 10, 9, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlock")]
		[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlock")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlock")]
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlock")]
		[Field ("kSecAttrAccessibleAlways", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleAlways { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0)));
		[Mac (10, 10), iOS (8, 0)]
		[Field ("kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleWhenUnlockedThisDeviceOnly __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrAccessibleWhenUnlockedThisDeviceOnly", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleWhenUnlockedThisDeviceOnly { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessibleAlwaysThisDeviceOnly __attribute__((availability(macos, introduced=10.9, deprecated=10.14))) __attribute__((availability(ios, introduced=4.0, deprecated=12.0)));
		[Introduced (PlatformName.MacOSX, 10, 9, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		[Deprecated (PlatformName.MacOSX, 10, 14, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		[Introduced (PlatformName.iOS, 4, 0, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use an accessibility level that provides some user protection, such as kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly")]
		[Field ("kSecAttrAccessibleAlwaysThisDeviceOnly", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessibleAlwaysThisDeviceOnly { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolFTP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolFTP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolFTP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolFTPAccount __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolFTPAccount", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolFTPAccount { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolHTTP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolHTTP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolHTTP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolIRC __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolIRC", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolIRC { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolNNTP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolNNTP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolNNTP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolPOP3 __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolPOP3", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolPOP3 { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolSMTP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolSMTP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolSMTP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolSOCKS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolSOCKS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolSOCKS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolIMAP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolIMAP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolIMAP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolLDAP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolLDAP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolLDAP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolAppleTalk __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolAppleTalk", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolAppleTalk { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolAFP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolAFP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolAFP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolTelnet __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolTelnet", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolTelnet { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolSSH __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolSSH", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolSSH { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolFTPS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolFTPS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolFTPS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolHTTPS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolHTTPS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolHTTPS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolHTTPProxy __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolHTTPProxy", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolHTTPProxy { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolHTTPSProxy __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolHTTPSProxy", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolHTTPSProxy { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolFTPProxy __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolFTPProxy", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolFTPProxy { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolSMB __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolSMB", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolSMB { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolRTSP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolRTSP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolRTSP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolRTSPProxy __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolRTSPProxy", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolRTSPProxy { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolDAAP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolDAAP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolDAAP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolEPPC __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolEPPC", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolEPPC { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolIPP __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolIPP", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolIPP { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolNNTPS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolNNTPS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolNNTPS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolLDAPS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolLDAPS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolLDAPS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolTelnetS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolTelnetS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolTelnetS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolIMAPS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolIMAPS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolIMAPS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolIRCS __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolIRCS", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolIRCS { get; }

		// extern const CFStringRef _Nonnull kSecAttrProtocolPOP3S __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrProtocolPOP3S", "__Internal")]
		unsafe CFStringRef* kSecAttrProtocolPOP3S { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeNTLM __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeNTLM", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeNTLM { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeMSN __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeMSN", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeMSN { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeDPA __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeDPA", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeDPA { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeRPA __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeRPA", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeRPA { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeHTTPBasic __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeHTTPBasic", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeHTTPBasic { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeHTTPDigest __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeHTTPDigest", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeHTTPDigest { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeHTMLForm __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeHTMLForm", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeHTMLForm { get; }

		// extern const CFStringRef _Nonnull kSecAttrAuthenticationTypeDefault __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecAttrAuthenticationTypeDefault", "__Internal")]
		unsafe CFStringRef* kSecAttrAuthenticationTypeDefault { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyClassPublic __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecAttrKeyClassPublic", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyClassPublic { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyClassPrivate __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecAttrKeyClassPrivate", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyClassPrivate { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyClassSymmetric __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecAttrKeyClassSymmetric", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyClassSymmetric { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeRSA __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 7), iOS (2, 0)]
		[Field ("kSecAttrKeyTypeRSA", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeRSA { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeDSA __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeDSA", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeDSA { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeAES __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeAES", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeAES { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeDES __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeDES", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeDES { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyType3DES __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyType3DES", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyType3DES { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeRC4 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeRC4", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeRC4 { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeRC2 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeRC2", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeRC2 { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeCAST __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeCAST", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeCAST { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeECDSA __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrKeyTypeECDSA", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeECDSA { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeEC __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=4.0)));
		[Mac (10, 9), iOS (4, 0)]
		[Field ("kSecAttrKeyTypeEC", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeEC { get; }

		// extern const CFStringRef _Nonnull kSecAttrKeyTypeECSECPrimeRandom __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kSecAttrKeyTypeECSECPrimeRandom", "__Internal")]
		unsafe CFStringRef* kSecAttrKeyTypeECSECPrimeRandom { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRFHmacAlgSHA1 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRFHmacAlgSHA1", "__Internal")]
		unsafe CFStringRef* kSecAttrPRFHmacAlgSHA1 { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRFHmacAlgSHA224 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRFHmacAlgSHA224", "__Internal")]
		unsafe CFStringRef* kSecAttrPRFHmacAlgSHA224 { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRFHmacAlgSHA256 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRFHmacAlgSHA256", "__Internal")]
		unsafe CFStringRef* kSecAttrPRFHmacAlgSHA256 { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRFHmacAlgSHA384 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRFHmacAlgSHA384", "__Internal")]
		unsafe CFStringRef* kSecAttrPRFHmacAlgSHA384 { get; }

		// extern const CFStringRef _Nonnull kSecAttrPRFHmacAlgSHA512 __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecAttrPRFHmacAlgSHA512", "__Internal")]
		unsafe CFStringRef* kSecAttrPRFHmacAlgSHA512 { get; }

		// extern const CFStringRef _Nonnull kSecMatchPolicy __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchPolicy", "__Internal")]
		unsafe CFStringRef* kSecMatchPolicy { get; }

		// extern const CFStringRef _Nonnull kSecMatchItemList __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchItemList", "__Internal")]
		unsafe CFStringRef* kSecMatchItemList { get; }

		// extern const CFStringRef _Nonnull kSecMatchSearchList __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchSearchList", "__Internal")]
		unsafe CFStringRef* kSecMatchSearchList { get; }

		// extern const CFStringRef _Nonnull kSecMatchIssuers __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchIssuers", "__Internal")]
		unsafe CFStringRef* kSecMatchIssuers { get; }

		// extern const CFStringRef _Nonnull kSecMatchEmailAddressIfPresent __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchEmailAddressIfPresent", "__Internal")]
		unsafe CFStringRef* kSecMatchEmailAddressIfPresent { get; }

		// extern const CFStringRef _Nonnull kSecMatchSubjectContains __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchSubjectContains", "__Internal")]
		unsafe CFStringRef* kSecMatchSubjectContains { get; }

		// extern const CFStringRef _Nonnull kSecMatchSubjectStartsWith __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecMatchSubjectStartsWith", "__Internal")]
		unsafe CFStringRef* kSecMatchSubjectStartsWith { get; }

		// extern const CFStringRef _Nonnull kSecMatchSubjectEndsWith __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecMatchSubjectEndsWith", "__Internal")]
		unsafe CFStringRef* kSecMatchSubjectEndsWith { get; }

		// extern const CFStringRef _Nonnull kSecMatchSubjectWholeString __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecMatchSubjectWholeString", "__Internal")]
		unsafe CFStringRef* kSecMatchSubjectWholeString { get; }

		// extern const CFStringRef _Nonnull kSecMatchCaseInsensitive __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchCaseInsensitive", "__Internal")]
		unsafe CFStringRef* kSecMatchCaseInsensitive { get; }

		// extern const CFStringRef _Nonnull kSecMatchDiacriticInsensitive __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecMatchDiacriticInsensitive", "__Internal")]
		unsafe CFStringRef* kSecMatchDiacriticInsensitive { get; }

		// extern const CFStringRef _Nonnull kSecMatchWidthInsensitive __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecMatchWidthInsensitive", "__Internal")]
		unsafe CFStringRef* kSecMatchWidthInsensitive { get; }

		// extern const CFStringRef _Nonnull kSecMatchTrustedOnly __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchTrustedOnly", "__Internal")]
		unsafe CFStringRef* kSecMatchTrustedOnly { get; }

		// extern const CFStringRef _Nonnull kSecMatchValidOnDate __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchValidOnDate", "__Internal")]
		unsafe CFStringRef* kSecMatchValidOnDate { get; }

		// extern const CFStringRef _Nonnull kSecMatchLimit __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchLimit", "__Internal")]
		unsafe CFStringRef* kSecMatchLimit { get; }

		// extern const CFStringRef _Nonnull kSecMatchLimitOne __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchLimitOne", "__Internal")]
		unsafe CFStringRef* kSecMatchLimitOne { get; }

		// extern const CFStringRef _Nonnull kSecMatchLimitAll __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecMatchLimitAll", "__Internal")]
		unsafe CFStringRef* kSecMatchLimitAll { get; }

		// extern const CFStringRef _Nonnull kSecReturnData __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecReturnData", "__Internal")]
		unsafe CFStringRef* kSecReturnData { get; }

		// extern const CFStringRef _Nonnull kSecReturnAttributes __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecReturnAttributes", "__Internal")]
		unsafe CFStringRef* kSecReturnAttributes { get; }

		// extern const CFStringRef _Nonnull kSecReturnRef __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecReturnRef", "__Internal")]
		unsafe CFStringRef* kSecReturnRef { get; }

		// extern const CFStringRef _Nonnull kSecReturnPersistentRef __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecReturnPersistentRef", "__Internal")]
		unsafe CFStringRef* kSecReturnPersistentRef { get; }

		// extern const CFStringRef _Nonnull kSecValueData __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecValueData", "__Internal")]
		unsafe CFStringRef* kSecValueData { get; }

		// extern const CFStringRef _Nonnull kSecValueRef __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecValueRef", "__Internal")]
		unsafe CFStringRef* kSecValueRef { get; }

		// extern const CFStringRef _Nonnull kSecValuePersistentRef __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecValuePersistentRef", "__Internal")]
		unsafe CFStringRef* kSecValuePersistentRef { get; }

		// extern const CFStringRef _Nonnull kSecUseItemList __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0, deprecated=12.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=12.0))) __attribute__((availability(watchos, introduced=1.0, deprecated=5.0))) __attribute__((availability(macCatalyst, unavailable)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Not implemented on this platform")]
		[Deprecated (PlatformName.iOS, 12, 0, message: "Not implemented on this platform")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Not implemented on this platform")]
		[Deprecated (PlatformName.TvOS, 12, 0, message: "Not implemented on this platform")]
		[Introduced (PlatformName.WatchOS, 1, 0, message: "Not implemented on this platform")]
		[Deprecated (PlatformName.WatchOS, 5, 0, message: "Not implemented on this platform")]
		[Unavailable (PlatformName.MacCatalyst)]
		[Mac (10, 6)]
		[Field ("kSecUseItemList", "__Internal"), Advice ("This API is not available when using UIKit on macOS.")]
		unsafe CFStringRef* kSecUseItemList { get; }

		// extern const CFStringRef _Nonnull kSecUseKeychain __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecUseKeychain", "__Internal")]
		unsafe CFStringRef* kSecUseKeychain { get; }

		// extern const CFStringRef _Nonnull kSecUseOperationPrompt __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0)));
		[Mac (10, 10), iOS (8, 0)]
		[Field ("kSecUseOperationPrompt", "__Internal")]
		unsafe CFStringRef* kSecUseOperationPrompt { get; }

		// extern const CFStringRef _Nonnull kSecUseNoAuthenticationUI __attribute__((availability(macos, introduced=10.10, deprecated=10.11))) __attribute__((availability(ios, introduced=8.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use kSecUseAuthenticationUI instead.")]
		[Deprecated (PlatformName.MacOSX, 10, 11, message: "Use kSecUseAuthenticationUI instead.")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use kSecUseAuthenticationUI instead.")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use kSecUseAuthenticationUI instead.")]
		[Field ("kSecUseNoAuthenticationUI", "__Internal")]
		unsafe CFStringRef* kSecUseNoAuthenticationUI { get; }

		// extern const CFStringRef _Nonnull kSecUseAuthenticationUI __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecUseAuthenticationUI", "__Internal")]
		unsafe CFStringRef* kSecUseAuthenticationUI { get; }

		// extern const CFStringRef _Nonnull kSecUseAuthenticationContext __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecUseAuthenticationContext", "__Internal")]
		unsafe CFStringRef* kSecUseAuthenticationContext { get; }

		// extern const CFStringRef _Nonnull kSecUseDataProtectionKeychain __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
		[Mac (10, 15), iOS (13, 0)]
		[Field ("kSecUseDataProtectionKeychain", "__Internal")]
		unsafe CFStringRef* kSecUseDataProtectionKeychain { get; }

		// extern const CFStringRef _Nonnull kSecUseAuthenticationUIAllow __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecUseAuthenticationUIAllow", "__Internal")]
		unsafe CFStringRef* kSecUseAuthenticationUIAllow { get; }

		// extern const CFStringRef _Nonnull kSecUseAuthenticationUIFail __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecUseAuthenticationUIFail", "__Internal")]
		unsafe CFStringRef* kSecUseAuthenticationUIFail { get; }

		// extern const CFStringRef _Nonnull kSecUseAuthenticationUISkip __attribute__((availability(macos, introduced=10.11))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 11), iOS (9, 0)]
		[Field ("kSecUseAuthenticationUISkip", "__Internal")]
		unsafe CFStringRef* kSecUseAuthenticationUISkip { get; }

		// extern const CFStringRef _Nonnull kSecAttrTokenIDSecureEnclave __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=9.0)));
		[Mac (10, 12), iOS (9, 0)]
		[Field ("kSecAttrTokenIDSecureEnclave", "__Internal")]
		unsafe CFStringRef* kSecAttrTokenIDSecureEnclave { get; }

		// extern const CFStringRef _Nonnull kSecAttrAccessGroupToken __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0)));
		[Mac (10, 12), iOS (10, 0)]
		[Field ("kSecAttrAccessGroupToken", "__Internal")]
		unsafe CFStringRef* kSecAttrAccessGroupToken { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSecPrivateKeyAttrs __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kSecPrivateKeyAttrs", "__Internal")]
		unsafe CFStringRef* kSecPrivateKeyAttrs { get; }

		// extern const CFStringRef _Nonnull kSecPublicKeyAttrs __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kSecPublicKeyAttrs", "__Internal")]
		unsafe CFStringRef* kSecPublicKeyAttrs { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureRaw __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureRaw", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureRaw { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPSSSHA1 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPSSSHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPSSSHA224 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPSSSHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPSSSHA256 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPSSSHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPSSSHA384 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPSSSHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureDigestPSSSHA512 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureDigestPSSSHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureDigestPSSSHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePSSSHA1 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePSSSHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePSSSHA224 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePSSSHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePSSSHA256 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePSSSHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePSSSHA384 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePSSSHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSASignatureMessagePSSSHA512 __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmRSASignatureMessagePSSSHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSASignatureMessagePSSSHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureRFC4754 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureRFC4754", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureRFC4754 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureDigestX962SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureDigestX962SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureDigestX962SHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureMessageX962SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureMessageX962SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureMessageX962SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureMessageX962SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureMessageX962SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureMessageX962SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureMessageX962SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureMessageX962SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDSASignatureMessageX962SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDSASignatureMessageX962SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDSASignatureMessageX962SHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionRaw __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionRaw", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionRaw { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionPKCS1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionPKCS1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionPKCS1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM __attribute__((availability(macos, introduced=10.13))) __attribute__((availability(ios, introduced=11.0))) __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(watchos, introduced=4.0)));
		[Watch (4, 0), TV (11, 0), Mac (10, 13), iOS (11, 0)]
		[Field ("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandard __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandard", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandard { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactor __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactor", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactor { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384 { get; }

		// extern const SecKeyAlgorithm _Nonnull kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512 __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512", "__Internal")]
		unsafe SecKeyAlgorithm* kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512 { get; }

		// extern const SecKeyKeyExchangeParameter _Nonnull kSecKeyKeyExchangeParameterRequestedSize __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyKeyExchangeParameterRequestedSize", "__Internal")]
		unsafe SecKeyKeyExchangeParameter* kSecKeyKeyExchangeParameterRequestedSize { get; }

		// extern const SecKeyKeyExchangeParameter _Nonnull kSecKeyKeyExchangeParameterSharedInfo __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[Field ("kSecKeyKeyExchangeParameterSharedInfo", "__Internal")]
		unsafe SecKeyKeyExchangeParameter* kSecKeyKeyExchangeParameterSharedInfo { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSecPolicyAppleX509Basic __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleX509Basic", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleX509Basic { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleSSL __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleSSL", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleSSL { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleSMIME __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleSMIME", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleSMIME { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleEAP __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleEAP", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleEAP { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleIPsec __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleIPsec", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleIPsec { get; }

		// extern const CFStringRef _Nonnull kSecPolicyApplePKINITClient __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macCatalyst, unavailable)));
		[Unavailable (PlatformName.MacCatalyst)]
		[NoWatch, NoTV, NoiOS, Mac (10, 7)]
		[Field ("kSecPolicyApplePKINITClient", "__Internal"), Advice ("This API is not available when using UIKit on macOS.")]
		unsafe CFStringRef* kSecPolicyApplePKINITClient { get; }

		// extern const CFStringRef _Nonnull kSecPolicyApplePKINITServer __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macCatalyst, unavailable)));
		[Unavailable (PlatformName.MacCatalyst)]
		[NoWatch, NoTV, NoiOS, Mac (10, 7)]
		[Field ("kSecPolicyApplePKINITServer", "__Internal"), Advice ("This API is not available when using UIKit on macOS.")]
		unsafe CFStringRef* kSecPolicyApplePKINITServer { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleCodeSigning __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleCodeSigning", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleCodeSigning { get; }

		// extern const CFStringRef _Nonnull kSecPolicyMacAppStoreReceipt __attribute__((availability(ios, introduced=9.0)));
		[iOS (9, 0)]
		[Field ("kSecPolicyMacAppStoreReceipt", "__Internal")]
		unsafe CFStringRef* kSecPolicyMacAppStoreReceipt { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleIDValidation __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleIDValidation", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleIDValidation { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleTimeStamping __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleTimeStamping", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleTimeStamping { get; }

		// extern const CFStringRef _Nonnull kSecPolicyAppleRevocation __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyAppleRevocation", "__Internal")]
		unsafe CFStringRef* kSecPolicyAppleRevocation { get; }

		// extern const CFStringRef _Nonnull kSecPolicyApplePassbookSigning __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyApplePassbookSigning", "__Internal")]
		unsafe CFStringRef* kSecPolicyApplePassbookSigning { get; }

		// extern const CFStringRef _Nonnull kSecPolicyApplePayIssuerEncryption __attribute__((availability(ios, introduced=9.0)));
		[iOS (9, 0)]
		[Field ("kSecPolicyApplePayIssuerEncryption", "__Internal")]
		unsafe CFStringRef* kSecPolicyApplePayIssuerEncryption { get; }

		// extern const CFStringRef _Nonnull kSecPolicyOid __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyOid", "__Internal")]
		unsafe CFStringRef* kSecPolicyOid { get; }

		// extern const CFStringRef _Nonnull kSecPolicyName __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyName", "__Internal")]
		unsafe CFStringRef* kSecPolicyName { get; }

		// extern const CFStringRef _Nonnull kSecPolicyClient __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyClient", "__Internal")]
		unsafe CFStringRef* kSecPolicyClient { get; }

		// extern const CFStringRef _Nonnull kSecPolicyRevocationFlags __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyRevocationFlags", "__Internal")]
		unsafe CFStringRef* kSecPolicyRevocationFlags { get; }

		// extern const CFStringRef _Nonnull kSecPolicyTeamIdentifier __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPolicyTeamIdentifier", "__Internal")]
		unsafe CFStringRef* kSecPolicyTeamIdentifier { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const SecRandomRef _Nonnull kSecRandomDefault __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kSecRandomDefault", "__Internal")]
		unsafe SecRandomRef* kSecRandomDefault { get; }

		// extern const CFStringRef _Nonnull kSecImportExportPassphrase __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportExportPassphrase", "__Internal")]
		unsafe CFStringRef* kSecImportExportPassphrase { get; }

		// extern const CFStringRef _Nonnull kSecImportExportKeychain __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecImportExportKeychain", "__Internal")]
		unsafe CFStringRef* kSecImportExportKeychain { get; }

		// extern const CFStringRef _Nonnull kSecImportExportAccess __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, unavailable)));
		[NoiOS, Mac (10, 7)]
		[Field ("kSecImportExportAccess", "__Internal")]
		unsafe CFStringRef* kSecImportExportAccess { get; }

		// extern const CFStringRef _Nonnull kSecImportItemLabel __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportItemLabel", "__Internal")]
		unsafe CFStringRef* kSecImportItemLabel { get; }

		// extern const CFStringRef _Nonnull kSecImportItemKeyID __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportItemKeyID", "__Internal")]
		unsafe CFStringRef* kSecImportItemKeyID { get; }

		// extern const CFStringRef _Nonnull kSecImportItemTrust __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportItemTrust", "__Internal")]
		unsafe CFStringRef* kSecImportItemTrust { get; }

		// extern const CFStringRef _Nonnull kSecImportItemCertChain __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportItemCertChain", "__Internal")]
		unsafe CFStringRef* kSecImportItemCertChain { get; }

		// extern const CFStringRef _Nonnull kSecImportItemIdentity __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=2.0)));
		[Mac (10, 6), iOS (2, 0)]
		[Field ("kSecImportItemIdentity", "__Internal")]
		unsafe CFStringRef* kSecImportItemIdentity { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSecPropertyTypeTitle __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPropertyTypeTitle", "__Internal")]
		unsafe CFStringRef* kSecPropertyTypeTitle { get; }

		// extern const CFStringRef _Nonnull kSecPropertyTypeError __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecPropertyTypeError", "__Internal")]
		unsafe CFStringRef* kSecPropertyTypeError { get; }

		// extern const CFStringRef _Nonnull kSecTrustEvaluationDate __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustEvaluationDate", "__Internal")]
		unsafe CFStringRef* kSecTrustEvaluationDate { get; }

		// extern const CFStringRef _Nonnull kSecTrustExtendedValidation __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustExtendedValidation", "__Internal")]
		unsafe CFStringRef* kSecTrustExtendedValidation { get; }

		// extern const CFStringRef _Nonnull kSecTrustOrganizationName __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustOrganizationName", "__Internal")]
		unsafe CFStringRef* kSecTrustOrganizationName { get; }

		// extern const CFStringRef _Nonnull kSecTrustResultValue __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustResultValue", "__Internal")]
		unsafe CFStringRef* kSecTrustResultValue { get; }

		// extern const CFStringRef _Nonnull kSecTrustRevocationChecked __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustRevocationChecked", "__Internal")]
		unsafe CFStringRef* kSecTrustRevocationChecked { get; }

		// extern const CFStringRef _Nonnull kSecTrustRevocationValidUntilDate __attribute__((availability(ios, introduced=7.0)));
		[iOS (7, 0)]
		[Field ("kSecTrustRevocationValidUntilDate", "__Internal")]
		unsafe CFStringRef* kSecTrustRevocationValidUntilDate { get; }

		// extern const CFStringRef _Nonnull kSecTrustCertificateTransparency __attribute__((availability(ios, introduced=9.0)));
		[iOS (9, 0)]
		[Field ("kSecTrustCertificateTransparency", "__Internal")]
		unsafe CFStringRef* kSecTrustCertificateTransparency { get; }

		// extern const CFStringRef _Nonnull kSecTrustCertificateTransparencyWhiteList __attribute__((availability(ios, introduced=10.0, deprecated=11.0)));
		[Introduced (PlatformName.iOS, 10, 0)]
		[Deprecated (PlatformName.iOS, 11, 0)]
		[Field ("kSecTrustCertificateTransparencyWhiteList", "__Internal")]
		unsafe CFStringRef* kSecTrustCertificateTransparencyWhiteList { get; }
	}

	// typedef void (^SecTrustCallback)(SecTrustRef _Nonnull, SecTrustResultType);
	unsafe delegate void SecTrustCallback (SecTrustRef* arg0, uint arg1);

	// typedef void (^SecTrustWithErrorCallback)(SecTrustRef _Nonnull, _Bool, CFErrorRef _Nullable);
	unsafe delegate void SecTrustWithErrorCallback (SecTrustRef* arg0, bool arg1, [NullAllowed] CFErrorRef* arg2);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSecSharedPassword __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(macos, unavailable))) __attribute__((availability(macCatalyst, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
		[Unavailable (PlatformName.MacCatalyst)]
		[NoWatch, NoTV, NoMac, iOS (8, 0)]
		[Field ("kSecSharedPassword", "__Internal"), Advice ("This API is not available when using UIKit on macOS.")]
		unsafe CFStringRef* kSecSharedPassword { get; }
	}

	// typedef void (^sec_protocol_pre_shared_key_selection_complete_t)(dispatch_data_t _Nullable);
	unsafe delegate void sec_protocol_pre_shared_key_selection_complete_t ([NullAllowed] dispatch_data_t* arg0);

	// typedef void (^sec_protocol_pre_shared_key_selection_t)(sec_protocol_metadata_t _Nonnull, dispatch_data_t _Nullable, sec_protocol_pre_shared_key_selection_complete_t _Nonnull);
	unsafe delegate void sec_protocol_pre_shared_key_selection_t (sec_protocol_metadata_t* arg0, [NullAllowed] dispatch_data_t* arg1, sec_protocol_pre_shared_key_selection_complete_t arg2);

	// typedef void (^sec_protocol_key_update_complete_t)();
	delegate void sec_protocol_key_update_complete_t ();

	// typedef void (^sec_protocol_key_update_t)(sec_protocol_metadata_t _Nonnull, sec_protocol_key_update_complete_t _Nonnull);
	unsafe delegate void sec_protocol_key_update_t (sec_protocol_metadata_t* arg0, sec_protocol_key_update_complete_t arg1);

	// typedef void (^sec_protocol_challenge_complete_t)(sec_identity_t _Nullable);
	unsafe delegate void sec_protocol_challenge_complete_t ([NullAllowed] sec_identity_t* arg0);

	// typedef void (^sec_protocol_challenge_t)(sec_protocol_metadata_t _Nonnull, sec_protocol_challenge_complete_t _Nonnull);
	unsafe delegate void sec_protocol_challenge_t (sec_protocol_metadata_t* arg0, sec_protocol_challenge_complete_t arg1);

	// typedef void (^sec_protocol_verify_complete_t)(_Bool);
	delegate void sec_protocol_verify_complete_t (bool arg0);

	// typedef void (^sec_protocol_verify_t)(sec_protocol_metadata_t _Nonnull, sec_trust_t _Nonnull, sec_protocol_verify_complete_t _Nonnull);
	unsafe delegate void sec_protocol_verify_t (sec_protocol_metadata_t* arg0, sec_trust_t* arg1, sec_protocol_verify_complete_t arg2);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSURLCredential;
		[Field ("NSURLCredential", "__Internal")]
		int NSURLCredential { get; }

		// extern int NSURLCredential;
		[Field ("NSURLCredential", "__Internal")]
		int NSURLCredential { get; }

		// extern int NSURLCredential;
		[Field ("NSURLCredential", "__Internal")]
		int NSURLCredential { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceHTTP __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSURLProtectionSpaceHTTP", "__Internal")]
		unsafe int* NSURLProtectionSpaceHTTP { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceHTTPS __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSURLProtectionSpaceHTTPS", "__Internal")]
		unsafe int* NSURLProtectionSpaceHTTPS { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceFTP __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSURLProtectionSpaceFTP", "__Internal")]
		unsafe int* NSURLProtectionSpaceFTP { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceHTTPProxy;
		[Field ("NSURLProtectionSpaceHTTPProxy", "__Internal")]
		unsafe int* NSURLProtectionSpaceHTTPProxy { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceHTTPSProxy;
		[Field ("NSURLProtectionSpaceHTTPSProxy", "__Internal")]
		unsafe int* NSURLProtectionSpaceHTTPSProxy { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceFTPProxy;
		[Field ("NSURLProtectionSpaceFTPProxy", "__Internal")]
		unsafe int* NSURLProtectionSpaceFTPProxy { get; }

		// extern int *const _Nonnull NSURLProtectionSpaceSOCKSProxy;
		[Field ("NSURLProtectionSpaceSOCKSProxy", "__Internal")]
		unsafe int* NSURLProtectionSpaceSOCKSProxy { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodDefault;
		[Field ("NSURLAuthenticationMethodDefault", "__Internal")]
		unsafe int* NSURLAuthenticationMethodDefault { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodHTTPBasic;
		[Field ("NSURLAuthenticationMethodHTTPBasic", "__Internal")]
		unsafe int* NSURLAuthenticationMethodHTTPBasic { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodHTTPDigest;
		[Field ("NSURLAuthenticationMethodHTTPDigest", "__Internal")]
		unsafe int* NSURLAuthenticationMethodHTTPDigest { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodHTMLForm;
		[Field ("NSURLAuthenticationMethodHTMLForm", "__Internal")]
		unsafe int* NSURLAuthenticationMethodHTMLForm { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodNTLM __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSURLAuthenticationMethodNTLM", "__Internal")]
		unsafe int* NSURLAuthenticationMethodNTLM { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodNegotiate __attribute__((availability(macos, introduced=10.5))) __attribute__((availability(ios, introduced=2.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 5), iOS (2, 0)]
		[Field ("NSURLAuthenticationMethodNegotiate", "__Internal")]
		unsafe int* NSURLAuthenticationMethodNegotiate { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodClientCertificate __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (3, 0)]
		[Field ("NSURLAuthenticationMethodClientCertificate", "__Internal")]
		unsafe int* NSURLAuthenticationMethodClientCertificate { get; }

		// extern int *const _Nonnull NSURLAuthenticationMethodServerTrust __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (3, 0)]
		[Field ("NSURLAuthenticationMethodServerTrust", "__Internal")]
		unsafe int* NSURLAuthenticationMethodServerTrust { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int *const _Nonnull NSURLCredentialStorageRemoveSynchronizableCredentials __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLCredentialStorageRemoveSynchronizableCredentials", "__Internal")]
		unsafe int* NSURLCredentialStorageRemoveSynchronizableCredentials { get; }

		// extern const CFStringRef _Nonnull kCFErrorDomainCFNetwork __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFErrorDomainCFNetwork", "__Internal")]
		unsafe CFStringRef* kCFErrorDomainCFNetwork { get; }

		// extern const CFStringRef _Nonnull kCFErrorDomainWinSock __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFErrorDomainWinSock", "__Internal")]
		unsafe CFStringRef* kCFErrorDomainWinSock { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFURLErrorFailingURLErrorKey __attribute__((availability(ios, introduced=2.2)));
		[iOS (2, 2)]
		[Field ("kCFURLErrorFailingURLErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLErrorFailingURLErrorKey { get; }

		// extern const CFStringRef _Nonnull kCFURLErrorFailingURLStringErrorKey __attribute__((availability(ios, introduced=2.2)));
		[iOS (2, 2)]
		[Field ("kCFURLErrorFailingURLStringErrorKey", "__Internal")]
		unsafe CFStringRef* kCFURLErrorFailingURLStringErrorKey { get; }

		// extern const CFStringRef _Nonnull kCFGetAddrInfoFailureKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFGetAddrInfoFailureKey", "__Internal")]
		unsafe CFStringRef* kCFGetAddrInfoFailureKey { get; }

		// extern const CFStringRef _Nonnull kCFSOCKSStatusCodeKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFSOCKSStatusCodeKey", "__Internal")]
		unsafe CFStringRef* kCFSOCKSStatusCodeKey { get; }

		// extern const CFStringRef _Nonnull kCFSOCKSVersionKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFSOCKSVersionKey", "__Internal")]
		unsafe CFStringRef* kCFSOCKSVersionKey { get; }

		// extern const CFStringRef _Nonnull kCFSOCKSNegotiationMethodKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFSOCKSNegotiationMethodKey", "__Internal")]
		unsafe CFStringRef* kCFSOCKSNegotiationMethodKey { get; }

		// extern const CFStringRef _Nonnull kCFDNSServiceFailureKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFDNSServiceFailureKey", "__Internal")]
		unsafe CFStringRef* kCFDNSServiceFailureKey { get; }

		// extern const CFStringRef _Nonnull kCFFTPStatusCodeKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFFTPStatusCodeKey", "__Internal")]
		unsafe CFStringRef* kCFFTPStatusCodeKey { get; }

		// extern const SInt32 kCFStreamErrorDomainNetDB __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainNetDB", "__Internal")]
		int kCFStreamErrorDomainNetDB { get; }

		// extern const SInt32 kCFStreamErrorDomainSystemConfiguration __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainSystemConfiguration", "__Internal")]
		int kCFStreamErrorDomainSystemConfiguration { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const SInt32 kCFStreamErrorDomainMach __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainMach", "__Internal")]
		int kCFStreamErrorDomainMach { get; }

		// extern const SInt32 kCFStreamErrorDomainNetServices __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainNetServices", "__Internal")]
		int kCFStreamErrorDomainNetServices { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFStreamPropertySSLContext __attribute__((availability(ios, introduced=5.0)));
		[iOS (5, 0)]
		[Field ("kCFStreamPropertySSLContext", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySSLContext { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySSLPeerTrust __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySSLPeerTrust", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySSLPeerTrust { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLValidatesCertificateChain __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSSLValidatesCertificateChain", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLValidatesCertificateChain { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySSLSettings __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySSLSettings", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySSLSettings { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLLevel __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSSLLevel", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLLevel { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLPeerName __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSSLPeerName", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLPeerName { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLCertificates __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSSLCertificates", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLCertificates { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLIsServer __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamSSLIsServer", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLIsServer { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceType __attribute__((availability(ios, introduced=4.0)));
		[iOS (4, 0)]
		[Field ("kCFStreamNetworkServiceType", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceType { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeVideo __attribute__((availability(ios, introduced=5.0)));
		[iOS (5, 0)]
		[Field ("kCFStreamNetworkServiceTypeVideo", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeVideo { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeVoice __attribute__((availability(ios, introduced=5.0)));
		[iOS (5, 0)]
		[Field ("kCFStreamNetworkServiceTypeVoice", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeVoice { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeBackground __attribute__((availability(ios, introduced=5.0)));
		[iOS (5, 0)]
		[Field ("kCFStreamNetworkServiceTypeBackground", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeBackground { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeResponsiveData __attribute__((availability(ios, introduced=6.0)));
		[iOS (6, 0)]
		[Field ("kCFStreamNetworkServiceTypeResponsiveData", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeResponsiveData { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeCallSignaling __attribute__((availability(ios, introduced=10.0)));
		[iOS (10, 0)]
		[Field ("kCFStreamNetworkServiceTypeCallSignaling", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeCallSignaling { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeAVStreaming __attribute__((availability(ios, introduced=6.0)));
		[iOS (6, 0)]
		[Field ("kCFStreamNetworkServiceTypeAVStreaming", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeAVStreaming { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeResponsiveAV __attribute__((availability(ios, introduced=6.0)));
		[iOS (6, 0)]
		[Field ("kCFStreamNetworkServiceTypeResponsiveAV", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeResponsiveAV { get; }

		// extern const CFStringRef _Nonnull kCFStreamNetworkServiceTypeVoIP __attribute__((availability(ios, introduced=4.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 4, 0, message: "use PushKit for VoIP control purposes")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "use PushKit for VoIP control purposes")]
		[Field ("kCFStreamNetworkServiceTypeVoIP", "__Internal")]
		unsafe CFStringRef* kCFStreamNetworkServiceTypeVoIP { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyNoCellular __attribute__((availability(ios, introduced=5.0)));
		[iOS (5, 0)]
		[Field ("kCFStreamPropertyNoCellular", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyNoCellular { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyConnectionIsCellular __attribute__((availability(ios, introduced=6.0)));
		[iOS (6, 0)]
		[Field ("kCFStreamPropertyConnectionIsCellular", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyConnectionIsCellular { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyAllowExpensiveNetworkAccess __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("kCFStreamPropertyAllowExpensiveNetworkAccess", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyAllowExpensiveNetworkAccess { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyConnectionIsExpensive __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("kCFStreamPropertyConnectionIsExpensive", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyConnectionIsExpensive { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyAllowConstrainedNetworkAccess __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("kCFStreamPropertyAllowConstrainedNetworkAccess", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyAllowConstrainedNetworkAccess { get; }

		// extern const CFIndex kCFStreamErrorDomainWinSock __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainWinSock", "__Internal")]
		nint kCFStreamErrorDomainWinSock { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFStreamPropertyProxyLocalBypass __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertyProxyLocalBypass", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyProxyLocalBypass { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySocketRemoteHost __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySocketRemoteHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySocketRemoteHost { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySocketRemoteNetService __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamPropertySocketRemoteNetService", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySocketRemoteNetService { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySocketExtendedBackgroundIdleMode __attribute__((availability(ios, introduced=9.0)));
		[iOS (9, 0)]
		[Field ("kCFStreamPropertySocketExtendedBackgroundIdleMode", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySocketExtendedBackgroundIdleMode { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertySSLPeerCertificates __attribute__((availability(ios, introduced=2.0, deprecated=4.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 4, 0)]
		[Field ("kCFStreamPropertySSLPeerCertificates", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertySSLPeerCertificates { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLAllowsExpiredCertificates __attribute__((availability(ios, introduced=2.0, deprecated=4.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 4, 0)]
		[Field ("kCFStreamSSLAllowsExpiredCertificates", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLAllowsExpiredCertificates { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLAllowsExpiredRoots __attribute__((availability(ios, introduced=2.0, deprecated=4.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 4, 0)]
		[Field ("kCFStreamSSLAllowsExpiredRoots", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLAllowsExpiredRoots { get; }

		// extern const CFStringRef _Nonnull kCFStreamSSLAllowsAnyRoot __attribute__((availability(ios, introduced=2.0, deprecated=4.0)));
		[Introduced (PlatformName.iOS, 2, 0)]
		[Deprecated (PlatformName.iOS, 4, 0)]
		[Field ("kCFStreamSSLAllowsAnyRoot", "__Internal")]
		unsafe CFStringRef* kCFStreamSSLAllowsAnyRoot { get; }

		// extern const SInt32 kCFStreamErrorDomainFTP __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainFTP", "__Internal")]
		int kCFStreamErrorDomainFTP { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPUserName __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPUserName", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPUserName { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPPassword __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPPassword", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPPassword { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPUsePassiveMode __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPUsePassiveMode", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPUsePassiveMode { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPResourceSize __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPResourceSize", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPResourceSize { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPFetchResourceInfo __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPFetchResourceInfo", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPFetchResourceInfo { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPFileTransferOffset __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPFileTransferOffset", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPFileTransferOffset { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPAttemptPersistentConnection __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPAttemptPersistentConnection", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPAttemptPersistentConnection { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPProxy __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPProxy", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPProxy { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPProxyHost __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPProxyHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPProxyHost { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPProxyPort __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPProxyPort", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPProxyPort { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPProxyUser __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPProxyUser", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPProxyUser { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyFTPProxyPassword __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFStreamPropertyFTPProxyPassword", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyFTPProxyPassword { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceMode __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceMode", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceMode { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceName __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceName", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceName { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceOwner __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceOwner", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceOwner { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceGroup __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceGroup", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceGroup { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceLink __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceLink", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceLink { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceSize __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceSize", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceSize { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceType __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceType", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceType { get; }

		// extern const CFStringRef _Nonnull kCFFTPResourceModDate __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSessionAPI for ftp requests")]
		[Field ("kCFFTPResourceModDate", "__Internal")]
		unsafe CFStringRef* kCFFTPResourceModDate { get; }

		// extern const CFStringRef _Nonnull kCFHTTPVersion1_0 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPVersion1_0", "__Internal")]
		unsafe CFStringRef* kCFHTTPVersion1_0 { get; }

		// extern const CFStringRef _Nonnull kCFHTTPVersion1_1 __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPVersion1_1", "__Internal")]
		unsafe CFStringRef* kCFHTTPVersion1_1 { get; }

		// extern const CFStringRef _Nonnull kCFHTTPVersion2_0 __attribute__((availability(ios, introduced=8.0)));
		[iOS (8, 0)]
		[Field ("kCFHTTPVersion2_0", "__Internal")]
		unsafe CFStringRef* kCFHTTPVersion2_0 { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeBasic __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationSchemeBasic", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeBasic { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeDigest __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationSchemeDigest", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeDigest { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeNTLM __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationSchemeNTLM", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeNTLM { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeKerberos __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationSchemeKerberos", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeKerberos { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeNegotiate __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationSchemeNegotiate", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeNegotiate { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeNegotiate2 __attribute__((availability(ios, introduced=3.0)));
		[iOS (3, 0)]
		[Field ("kCFHTTPAuthenticationSchemeNegotiate2", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeNegotiate2 { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationSchemeXMobileMeAuthToken __attribute__((availability(ios, introduced=4.3)));
		[iOS (4, 3)]
		[Field ("kCFHTTPAuthenticationSchemeXMobileMeAuthToken", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationSchemeXMobileMeAuthToken { get; }

		// extern const SInt32 kCFStreamErrorDomainHTTP __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFStreamErrorDomainHTTP", "__Internal")]
		int kCFStreamErrorDomainHTTP { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPResponseHeader __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPResponseHeader", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPResponseHeader { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPFinalURL __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPFinalURL", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPFinalURL { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPFinalRequest __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPFinalRequest", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPFinalRequest { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPProxy __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPProxy", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPProxy { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPProxyHost __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPProxyHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPProxyHost { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPProxyPort __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPProxyPort", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPProxyPort { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPSProxyHost __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPSProxyHost", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPSProxyHost { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPSProxyPort __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPSProxyPort", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPSProxyPort { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPShouldAutoredirect __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPShouldAutoredirect", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPShouldAutoredirect { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPAttemptPersistentConnection __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPAttemptPersistentConnection", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPAttemptPersistentConnection { get; }

		// extern const CFStringRef _Nonnull kCFStreamPropertyHTTPRequestBytesWrittenCount __attribute__((availability(ios, introduced=2.0, deprecated=9.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLSession API for http requests")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use NSURLSession API for http requests")]
		[Field ("kCFStreamPropertyHTTPRequestBytesWrittenCount", "__Internal")]
		unsafe CFStringRef* kCFStreamPropertyHTTPRequestBytesWrittenCount { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationUsername __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationUsername", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationUsername { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationPassword __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationPassword", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationPassword { get; }

		// extern const CFStringRef _Nonnull kCFHTTPAuthenticationAccountDomain __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFHTTPAuthenticationAccountDomain", "__Internal")]
		unsafe CFStringRef* kCFHTTPAuthenticationAccountDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kCFProxyTypeKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeKey", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyHostNameKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyHostNameKey", "__Internal")]
		unsafe CFStringRef* kCFProxyHostNameKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyPortNumberKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyPortNumberKey", "__Internal")]
		unsafe CFStringRef* kCFProxyPortNumberKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyAutoConfigurationURLKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyAutoConfigurationURLKey", "__Internal")]
		unsafe CFStringRef* kCFProxyAutoConfigurationURLKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyAutoConfigurationJavaScriptKey __attribute__((availability(ios, introduced=3.0)));
		[iOS (3, 0)]
		[Field ("kCFProxyAutoConfigurationJavaScriptKey", "__Internal")]
		unsafe CFStringRef* kCFProxyAutoConfigurationJavaScriptKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyUsernameKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyUsernameKey", "__Internal")]
		unsafe CFStringRef* kCFProxyUsernameKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyPasswordKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyPasswordKey", "__Internal")]
		unsafe CFStringRef* kCFProxyPasswordKey { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeNone __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeNone", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeNone { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeHTTP __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeHTTP", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeHTTP { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeHTTPS __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeHTTPS", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeHTTPS { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeSOCKS __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeSOCKS", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeSOCKS { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeFTP __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeFTP", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeFTP { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeAutoConfigurationURL __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyTypeAutoConfigurationURL", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeAutoConfigurationURL { get; }

		// extern const CFStringRef _Nonnull kCFProxyTypeAutoConfigurationJavaScript __attribute__((availability(ios, introduced=3.0)));
		[iOS (3, 0)]
		[Field ("kCFProxyTypeAutoConfigurationJavaScript", "__Internal")]
		unsafe CFStringRef* kCFProxyTypeAutoConfigurationJavaScript { get; }

		// extern const CFStringRef _Nonnull kCFProxyAutoConfigurationHTTPResponseKey __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFProxyAutoConfigurationHTTPResponseKey", "__Internal")]
		unsafe CFStringRef* kCFProxyAutoConfigurationHTTPResponseKey { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesExceptionsList __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesExceptionsList", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesExceptionsList { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesExcludeSimpleHostnames __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesExcludeSimpleHostnames", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesExcludeSimpleHostnames { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesFTPEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesFTPEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesFTPEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesFTPPassive __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesFTPPassive", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesFTPPassive { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesFTPPort __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesFTPPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesFTPPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesFTPProxy __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesFTPProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesFTPProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesGopherEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesGopherEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesGopherEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesGopherPort __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesGopherPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesGopherPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesGopherProxy __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesGopherProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesGopherProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPEnable __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFNetworkProxiesHTTPEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPPort __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFNetworkProxiesHTTPPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPProxy __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFNetworkProxiesHTTPProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPSEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesHTTPSEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPSEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPSPort __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesHTTPSPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPSPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesHTTPSProxy __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesHTTPSProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesHTTPSProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesRTSPEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesRTSPEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesRTSPEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesRTSPPort __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesRTSPPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesRTSPPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesRTSPProxy __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesRTSPProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesRTSPProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesSOCKSEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesSOCKSEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesSOCKSEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesSOCKSPort __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesSOCKSPort", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesSOCKSPort { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesSOCKSProxy __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesSOCKSProxy", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesSOCKSProxy { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesProxyAutoConfigEnable __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFNetworkProxiesProxyAutoConfigEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesProxyAutoConfigEnable { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesProxyAutoConfigURLString __attribute__((availability(ios, introduced=2.0)));
		[iOS (2, 0)]
		[Field ("kCFNetworkProxiesProxyAutoConfigURLString", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesProxyAutoConfigURLString { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesProxyAutoConfigJavaScript __attribute__((availability(ios, introduced=3.0)));
		[iOS (3, 0)]
		[Field ("kCFNetworkProxiesProxyAutoConfigJavaScript", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesProxyAutoConfigJavaScript { get; }

		// extern const CFStringRef _Nonnull kCFNetworkProxiesProxyAutoDiscoveryEnable __attribute__((availability(ios, unavailable)));
		[NoiOS]
		[Field ("kCFNetworkProxiesProxyAutoDiscoveryEnable", "__Internal")]
		unsafe CFStringRef* kCFNetworkProxiesProxyAutoDiscoveryEnable { get; }

		// extern const NSErrorDomain _Nonnull NSURLErrorDomain;
		[Field ("NSURLErrorDomain", "__Internal")]
		unsafe int* NSURLErrorDomain { get; }

		// extern int *const _Nonnull NSURLErrorFailingURLErrorKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLErrorFailingURLErrorKey", "__Internal")]
		unsafe int* NSURLErrorFailingURLErrorKey { get; }

		// extern int *const _Nonnull NSURLErrorFailingURLStringErrorKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLErrorFailingURLStringErrorKey", "__Internal")]
		unsafe int* NSURLErrorFailingURLStringErrorKey { get; }

		// extern int *const _Nonnull NSErrorFailingURLStringKey __attribute__((availability(macos, introduced=10.0, deprecated=10.6))) __attribute__((availability(ios, introduced=2.0, deprecated=4.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 6, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Introduced (PlatformName.iOS, 2, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Deprecated (PlatformName.iOS, 4, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSURLErrorFailingURLStringErrorKey instead")]
		[Field ("NSErrorFailingURLStringKey", "__Internal")]
		unsafe int* NSErrorFailingURLStringKey { get; }

		// extern int *const _Nonnull NSURLErrorFailingURLPeerTrustErrorKey __attribute__((availability(macos, introduced=10.6))) __attribute__((availability(ios, introduced=4.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 6), iOS (4, 0)]
		[Field ("NSURLErrorFailingURLPeerTrustErrorKey", "__Internal")]
		unsafe int* NSURLErrorFailingURLPeerTrustErrorKey { get; }

		// extern int *const _Nonnull NSURLErrorBackgroundTaskCancelledReasonKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLErrorBackgroundTaskCancelledReasonKey", "__Internal")]
		unsafe int* NSURLErrorBackgroundTaskCancelledReasonKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const NSErrorUserInfoKey _Nonnull NSURLErrorNetworkUnavailableReasonKey __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(watchos, introduced=6.0))) __attribute__((availability(tvos, introduced=13.0)));
		[Watch (6, 0), TV (13, 0), Mac (10, 15), iOS (13, 0)]
		[Field ("NSURLErrorNetworkUnavailableReasonKey", "__Internal")]
		unsafe int* NSURLErrorNetworkUnavailableReasonKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSURLRequest;
		[Field ("NSURLRequest", "__Internal")]
		int NSURLRequest { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int *const _Nonnull NSGlobalDomain;
		[Field ("NSGlobalDomain", "__Internal")]
		unsafe int* NSGlobalDomain { get; }

		// extern int *const _Nonnull NSArgumentDomain;
		[Field ("NSArgumentDomain", "__Internal")]
		unsafe int* NSArgumentDomain { get; }

		// extern int *const _Nonnull NSRegistrationDomain;
		[Field ("NSRegistrationDomain", "__Internal")]
		unsafe int* NSRegistrationDomain { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSInteger;
		[Field ("NSInteger", "__Internal")]
		int NSInteger { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern const NSNotificationName _Nonnull NSUbiquitousUserDefaultsNoCloudAccountNotification __attribute__((availability(ios, introduced=9.3))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 3)]
		[Field ("NSUbiquitousUserDefaultsNoCloudAccountNotification", "__Internal")]
		unsafe int* NSUbiquitousUserDefaultsNoCloudAccountNotification { get; }

		// extern const NSNotificationName _Nonnull NSUbiquitousUserDefaultsDidChangeAccountsNotification __attribute__((availability(ios, introduced=9.3))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 3)]
		[Field ("NSUbiquitousUserDefaultsDidChangeAccountsNotification", "__Internal")]
		unsafe int* NSUbiquitousUserDefaultsDidChangeAccountsNotification { get; }

		// extern const NSNotificationName _Nonnull NSUbiquitousUserDefaultsCompletedInitialSyncNotification __attribute__((availability(ios, introduced=9.3))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0))) __attribute__((availability(macos, unavailable)));
		[Watch (2, 0), TV (9, 0), NoMac, iOS (9, 3)]
		[Field ("NSUbiquitousUserDefaultsCompletedInitialSyncNotification", "__Internal")]
		unsafe int* NSUbiquitousUserDefaultsCompletedInitialSyncNotification { get; }

		// extern const NSNotificationName _Nonnull NSUserDefaultsDidChangeNotification;
		[Field ("NSUserDefaultsDidChangeNotification", "__Internal")]
		unsafe int* NSUserDefaultsDidChangeNotification { get; }

		// extern const NSValueTransformerName _Nonnull NSNegateBooleanTransformerName __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (3, 0)]
		[Field ("NSNegateBooleanTransformerName", "__Internal")]
		unsafe int* NSNegateBooleanTransformerName { get; }

		// extern const NSValueTransformerName _Nonnull NSIsNilTransformerName __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (3, 0)]
		[Field ("NSIsNilTransformerName", "__Internal")]
		unsafe int* NSIsNilTransformerName { get; }

		// extern const NSValueTransformerName _Nonnull NSIsNotNilTransformerName __attribute__((availability(macos, introduced=10.3))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 3), iOS (3, 0)]
		[Field ("NSIsNotNilTransformerName", "__Internal")]
		unsafe int* NSIsNotNilTransformerName { get; }

		// extern const NSValueTransformerName _Nonnull NSUnarchiveFromDataTransformerName __attribute__((availability(macos, introduced=10.3, deprecated=10.14))) __attribute__((availability(ios, introduced=3.0, deprecated=12.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=5.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=12.0)));
		[Introduced (PlatformName.MacOSX, 10, 3)]
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		[Introduced (PlatformName.iOS, 3, 0)]
		[Deprecated (PlatformName.iOS, 12, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 5, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 12, 0)]
		[Field ("NSUnarchiveFromDataTransformerName", "__Internal")]
		unsafe int* NSUnarchiveFromDataTransformerName { get; }

		// extern const NSValueTransformerName _Nonnull NSKeyedUnarchiveFromDataTransformerName __attribute__((availability(macos, introduced=10.3, deprecated=10.14))) __attribute__((availability(ios, introduced=3.0, deprecated=12.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=5.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=12.0)));
		[Introduced (PlatformName.MacOSX, 10, 3)]
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		[Introduced (PlatformName.iOS, 3, 0)]
		[Deprecated (PlatformName.iOS, 12, 0)]
		[Introduced (PlatformName.WatchOS, 2, 0)]
		[Deprecated (PlatformName.WatchOS, 5, 0)]
		[Introduced (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 12, 0)]
		[Field ("NSKeyedUnarchiveFromDataTransformerName", "__Internal")]
		unsafe int* NSKeyedUnarchiveFromDataTransformerName { get; }

		// extern const NSValueTransformerName _Nonnull NSSecureUnarchiveFromDataTransformerName __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=12.0))) __attribute__((availability(watchos, introduced=5.0))) __attribute__((availability(tvos, introduced=12.0)));
		[Watch (5, 0), TV (12, 0), Mac (10, 14), iOS (12, 0)]
		[Field ("NSSecureUnarchiveFromDataTransformerName", "__Internal")]
		unsafe int* NSSecureUnarchiveFromDataTransformerName { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int Class;
		[Field ("Class", "__Internal")]
		int Class { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSXPCListener;
		[Field ("NSXPCListener", "__Internal")]
		int NSXPCListener { get; }

		// extern int NSXPCListener;
		[Field ("NSXPCListener", "__Internal")]
		int NSXPCListener { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSXPCInterface;
		[Field ("NSXPCInterface", "__Internal")]
		int NSXPCInterface { get; }

		// extern int NSSet;
		[Field ("NSSet", "__Internal")]
		int NSSet { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSPredicate;
		[Field ("NSPredicate", "__Internal")]
		int NSPredicate { get; }

		// extern int NSPredicate;
		[Field ("NSPredicate", "__Internal")]
		int NSPredicate { get; }

		// extern int NSPredicate;
		[Field ("NSPredicate", "__Internal")]
		int NSPredicate { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSPredicate;
		[Field ("NSPredicate", "__Internal")]
		int NSPredicate { get; }

		// extern int NSPredicate;
		[Field ("NSPredicate", "__Internal")]
		int NSPredicate { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSComparisonPredicate;
		[Field ("NSComparisonPredicate", "__Internal")]
		int NSComparisonPredicate { get; }

		// extern int NSComparisonPredicate;
		[Field ("NSComparisonPredicate", "__Internal")]
		int NSComparisonPredicate { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSCompoundPredicate;
		[Field ("NSCompoundPredicate", "__Internal")]
		int NSCompoundPredicate { get; }

		// extern int NSCompoundPredicate;
		[Field ("NSCompoundPredicate", "__Internal")]
		int NSCompoundPredicate { get; }

		// extern int NSCompoundPredicate;
		[Field ("NSCompoundPredicate", "__Internal")]
		int NSCompoundPredicate { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int NSExpression;
		[Field ("NSExpression", "__Internal")]
		int NSExpression { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSURL;
		[Field ("NSURL", "__Internal")]
		int NSURL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeTokenType __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeTokenType", "__Internal")]
		unsafe int* NSLinguisticTagSchemeTokenType { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeLexicalClass __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeLexicalClass", "__Internal")]
		unsafe int* NSLinguisticTagSchemeLexicalClass { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeNameType __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeNameType", "__Internal")]
		unsafe int* NSLinguisticTagSchemeNameType { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeNameTypeOrLexicalClass __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeNameTypeOrLexicalClass", "__Internal")]
		unsafe int* NSLinguisticTagSchemeNameTypeOrLexicalClass { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeLemma __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeLemma", "__Internal")]
		unsafe int* NSLinguisticTagSchemeLemma { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeLanguage __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeLanguage", "__Internal")]
		unsafe int* NSLinguisticTagSchemeLanguage { get; }

		// extern const NSLinguisticTagScheme _Nonnull NSLinguisticTagSchemeScript __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSchemeScript", "__Internal")]
		unsafe int* NSLinguisticTagSchemeScript { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagWord __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagWord", "__Internal")]
		unsafe int* NSLinguisticTagWord { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagPunctuation __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagPunctuation", "__Internal")]
		unsafe int* NSLinguisticTagPunctuation { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagWhitespace __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagWhitespace", "__Internal")]
		unsafe int* NSLinguisticTagWhitespace { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOther __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOther", "__Internal")]
		unsafe int* NSLinguisticTagOther { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagNoun __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagNoun", "__Internal")]
		unsafe int* NSLinguisticTagNoun { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagVerb __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagVerb", "__Internal")]
		unsafe int* NSLinguisticTagVerb { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagAdjective __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagAdjective", "__Internal")]
		unsafe int* NSLinguisticTagAdjective { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagAdverb __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagAdverb", "__Internal")]
		unsafe int* NSLinguisticTagAdverb { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagPronoun __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagPronoun", "__Internal")]
		unsafe int* NSLinguisticTagPronoun { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagDeterminer __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagDeterminer", "__Internal")]
		unsafe int* NSLinguisticTagDeterminer { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagParticle __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagParticle", "__Internal")]
		unsafe int* NSLinguisticTagParticle { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagPreposition __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagPreposition", "__Internal")]
		unsafe int* NSLinguisticTagPreposition { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagNumber __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagNumber", "__Internal")]
		unsafe int* NSLinguisticTagNumber { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagConjunction __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagConjunction", "__Internal")]
		unsafe int* NSLinguisticTagConjunction { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagInterjection __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagInterjection", "__Internal")]
		unsafe int* NSLinguisticTagInterjection { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagClassifier __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagClassifier", "__Internal")]
		unsafe int* NSLinguisticTagClassifier { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagIdiom __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagIdiom", "__Internal")]
		unsafe int* NSLinguisticTagIdiom { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOtherWord __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOtherWord", "__Internal")]
		unsafe int* NSLinguisticTagOtherWord { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagSentenceTerminator __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagSentenceTerminator", "__Internal")]
		unsafe int* NSLinguisticTagSentenceTerminator { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOpenQuote __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOpenQuote", "__Internal")]
		unsafe int* NSLinguisticTagOpenQuote { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagCloseQuote __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagCloseQuote", "__Internal")]
		unsafe int* NSLinguisticTagCloseQuote { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOpenParenthesis __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOpenParenthesis", "__Internal")]
		unsafe int* NSLinguisticTagOpenParenthesis { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagCloseParenthesis __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagCloseParenthesis", "__Internal")]
		unsafe int* NSLinguisticTagCloseParenthesis { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagWordJoiner __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagWordJoiner", "__Internal")]
		unsafe int* NSLinguisticTagWordJoiner { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagDash __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagDash", "__Internal")]
		unsafe int* NSLinguisticTagDash { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOtherPunctuation __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOtherPunctuation", "__Internal")]
		unsafe int* NSLinguisticTagOtherPunctuation { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagParagraphBreak __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagParagraphBreak", "__Internal")]
		unsafe int* NSLinguisticTagParagraphBreak { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOtherWhitespace __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOtherWhitespace", "__Internal")]
		unsafe int* NSLinguisticTagOtherWhitespace { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagPersonalName __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagPersonalName", "__Internal")]
		unsafe int* NSLinguisticTagPersonalName { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagPlaceName __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagPlaceName", "__Internal")]
		unsafe int* NSLinguisticTagPlaceName { get; }

		// extern const NSLinguisticTag _Nonnull NSLinguisticTagOrganizationName __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSLinguisticTagOrganizationName", "__Internal")]
		unsafe int* NSLinguisticTagOrganizationName { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int NSRange;
		[Field ("NSRange", "__Internal")]
		int NSRange { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int NSArray;
		[Field ("NSArray", "__Internal")]
		int NSArray { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int *const _Nonnull NSMetadataItemFSNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemFSNameKey", "__Internal")]
		unsafe int* NSMetadataItemFSNameKey { get; }

		// extern int *const _Nonnull NSMetadataItemDisplayNameKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemDisplayNameKey", "__Internal")]
		unsafe int* NSMetadataItemDisplayNameKey { get; }

		// extern int *const _Nonnull NSMetadataItemURLKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemURLKey", "__Internal")]
		unsafe int* NSMetadataItemURLKey { get; }

		// extern int *const _Nonnull NSMetadataItemPathKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemPathKey", "__Internal")]
		unsafe int* NSMetadataItemPathKey { get; }

		// extern int *const _Nonnull NSMetadataItemFSSizeKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemFSSizeKey", "__Internal")]
		unsafe int* NSMetadataItemFSSizeKey { get; }

		// extern int *const _Nonnull NSMetadataItemFSCreationDateKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemFSCreationDateKey", "__Internal")]
		unsafe int* NSMetadataItemFSCreationDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemFSContentChangeDateKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemFSContentChangeDateKey", "__Internal")]
		unsafe int* NSMetadataItemFSContentChangeDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemContentTypeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (8, 0)]
		[Field ("NSMetadataItemContentTypeKey", "__Internal")]
		unsafe int* NSMetadataItemContentTypeKey { get; }

		// extern int *const _Nonnull NSMetadataItemContentTypeTreeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (8, 0)]
		[Field ("NSMetadataItemContentTypeTreeKey", "__Internal")]
		unsafe int* NSMetadataItemContentTypeTreeKey { get; }

		// extern int *const _Nonnull NSMetadataItemIsUbiquitousKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataItemIsUbiquitousKey", "__Internal")]
		unsafe int* NSMetadataItemIsUbiquitousKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemHasUnresolvedConflictsKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemHasUnresolvedConflictsKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemHasUnresolvedConflictsKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsDownloadedKey __attribute__((availability(macos, introduced=10.7, deprecated=10.9))) __attribute__((availability(ios, introduced=5.0, deprecated=7.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0)));
		[Introduced (PlatformName.MacOSX, 10, 7, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.MacOSX, 10, 9, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.iOS, 5, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.iOS, 7, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use NSMetadataUbiquitousItemDownloadingStatusKey instead")]
		[Field ("NSMetadataUbiquitousItemIsDownloadedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsDownloadedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadingStatusKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadingStatusKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadingStatusKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadingStatusNotDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadingStatusNotDownloaded", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadingStatusNotDownloaded { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadingStatusDownloaded __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadingStatusDownloaded", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadingStatusDownloaded { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadingStatusCurrent __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadingStatusCurrent", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadingStatusCurrent { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsDownloadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemIsDownloadingKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsDownloadingKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsUploadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemIsUploadedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsUploadedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsUploadingKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemIsUploadingKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsUploadingKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemPercentDownloadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemPercentDownloadedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemPercentDownloadedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemPercentUploadedKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataUbiquitousItemPercentUploadedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemPercentUploadedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadingErrorKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadingErrorKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemUploadingErrorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSMetadataUbiquitousItemUploadingErrorKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemUploadingErrorKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemDownloadRequestedKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSMetadataUbiquitousItemDownloadRequestedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemDownloadRequestedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsExternalDocumentKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSMetadataUbiquitousItemIsExternalDocumentKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsExternalDocumentKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemContainerDisplayNameKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSMetadataUbiquitousItemContainerDisplayNameKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemContainerDisplayNameKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemURLInLocalContainerKey __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSMetadataUbiquitousItemURLInLocalContainerKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemURLInLocalContainerKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousItemIsSharedKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousItemIsSharedKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousItemIsSharedKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemCurrentUserRoleKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemCurrentUserRoleKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemCurrentUserRoleKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemCurrentUserPermissionsKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemOwnerNameComponentsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemOwnerNameComponentsKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemOwnerNameComponentsKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemMostRecentEditorNameComponentsKey { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemRoleOwner __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemRoleOwner", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemRoleOwner { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemRoleParticipant __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemRoleParticipant", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemRoleParticipant { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemPermissionsReadOnly __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemPermissionsReadOnly", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemPermissionsReadOnly { get; }

		// extern int *const _Nonnull NSMetadataUbiquitousSharedItemPermissionsReadWrite __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, Mac (10, 12), iOS (10, 0)]
		[Field ("NSMetadataUbiquitousSharedItemPermissionsReadWrite", "__Internal")]
		unsafe int* NSMetadataUbiquitousSharedItemPermissionsReadWrite { get; }

		// extern int *const _Nonnull NSMetadataItemAttributeChangeDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAttributeChangeDateKey", "__Internal")]
		unsafe int* NSMetadataItemAttributeChangeDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemKeywordsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemKeywordsKey", "__Internal")]
		unsafe int* NSMetadataItemKeywordsKey { get; }

		// extern int *const _Nonnull NSMetadataItemTitleKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTitleKey", "__Internal")]
		unsafe int* NSMetadataItemTitleKey { get; }

		// extern int *const _Nonnull NSMetadataItemAuthorsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAuthorsKey", "__Internal")]
		unsafe int* NSMetadataItemAuthorsKey { get; }

		// extern int *const _Nonnull NSMetadataItemEditorsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemEditorsKey", "__Internal")]
		unsafe int* NSMetadataItemEditorsKey { get; }

		// extern int *const _Nonnull NSMetadataItemParticipantsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemParticipantsKey", "__Internal")]
		unsafe int* NSMetadataItemParticipantsKey { get; }

		// extern int *const _Nonnull NSMetadataItemProjectsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemProjectsKey", "__Internal")]
		unsafe int* NSMetadataItemProjectsKey { get; }

		// extern int *const _Nonnull NSMetadataItemDownloadedDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDownloadedDateKey", "__Internal")]
		unsafe int* NSMetadataItemDownloadedDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemWhereFromsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemWhereFromsKey", "__Internal")]
		unsafe int* NSMetadataItemWhereFromsKey { get; }

		// extern int *const _Nonnull NSMetadataItemCommentKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCommentKey", "__Internal")]
		unsafe int* NSMetadataItemCommentKey { get; }

		// extern int *const _Nonnull NSMetadataItemCopyrightKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCopyrightKey", "__Internal")]
		unsafe int* NSMetadataItemCopyrightKey { get; }

		// extern int *const _Nonnull NSMetadataItemLastUsedDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLastUsedDateKey", "__Internal")]
		unsafe int* NSMetadataItemLastUsedDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemContentCreationDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemContentCreationDateKey", "__Internal")]
		unsafe int* NSMetadataItemContentCreationDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemContentModificationDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemContentModificationDateKey", "__Internal")]
		unsafe int* NSMetadataItemContentModificationDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemDateAddedKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDateAddedKey", "__Internal")]
		unsafe int* NSMetadataItemDateAddedKey { get; }

		// extern int *const _Nonnull NSMetadataItemDurationSecondsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDurationSecondsKey", "__Internal")]
		unsafe int* NSMetadataItemDurationSecondsKey { get; }

		// extern int *const _Nonnull NSMetadataItemContactKeywordsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemContactKeywordsKey", "__Internal")]
		unsafe int* NSMetadataItemContactKeywordsKey { get; }

		// extern int *const _Nonnull NSMetadataItemVersionKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemVersionKey", "__Internal")]
		unsafe int* NSMetadataItemVersionKey { get; }

		// extern int *const _Nonnull NSMetadataItemPixelHeightKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPixelHeightKey", "__Internal")]
		unsafe int* NSMetadataItemPixelHeightKey { get; }

		// extern int *const _Nonnull NSMetadataItemPixelWidthKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPixelWidthKey", "__Internal")]
		unsafe int* NSMetadataItemPixelWidthKey { get; }

		// extern int *const _Nonnull NSMetadataItemPixelCountKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPixelCountKey", "__Internal")]
		unsafe int* NSMetadataItemPixelCountKey { get; }

		// extern int *const _Nonnull NSMetadataItemColorSpaceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemColorSpaceKey", "__Internal")]
		unsafe int* NSMetadataItemColorSpaceKey { get; }

		// extern int *const _Nonnull NSMetadataItemBitsPerSampleKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemBitsPerSampleKey", "__Internal")]
		unsafe int* NSMetadataItemBitsPerSampleKey { get; }

		// extern int *const _Nonnull NSMetadataItemFlashOnOffKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFlashOnOffKey", "__Internal")]
		unsafe int* NSMetadataItemFlashOnOffKey { get; }

		// extern int *const _Nonnull NSMetadataItemFocalLengthKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFocalLengthKey", "__Internal")]
		unsafe int* NSMetadataItemFocalLengthKey { get; }

		// extern int *const _Nonnull NSMetadataItemAcquisitionMakeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAcquisitionMakeKey", "__Internal")]
		unsafe int* NSMetadataItemAcquisitionMakeKey { get; }

		// extern int *const _Nonnull NSMetadataItemAcquisitionModelKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAcquisitionModelKey", "__Internal")]
		unsafe int* NSMetadataItemAcquisitionModelKey { get; }

		// extern int *const _Nonnull NSMetadataItemISOSpeedKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemISOSpeedKey", "__Internal")]
		unsafe int* NSMetadataItemISOSpeedKey { get; }

		// extern int *const _Nonnull NSMetadataItemOrientationKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemOrientationKey", "__Internal")]
		unsafe int* NSMetadataItemOrientationKey { get; }

		// extern int *const _Nonnull NSMetadataItemLayerNamesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLayerNamesKey", "__Internal")]
		unsafe int* NSMetadataItemLayerNamesKey { get; }

		// extern int *const _Nonnull NSMetadataItemWhiteBalanceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemWhiteBalanceKey", "__Internal")]
		unsafe int* NSMetadataItemWhiteBalanceKey { get; }

		// extern int *const _Nonnull NSMetadataItemApertureKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemApertureKey", "__Internal")]
		unsafe int* NSMetadataItemApertureKey { get; }

		// extern int *const _Nonnull NSMetadataItemProfileNameKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemProfileNameKey", "__Internal")]
		unsafe int* NSMetadataItemProfileNameKey { get; }

		// extern int *const _Nonnull NSMetadataItemResolutionWidthDPIKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemResolutionWidthDPIKey", "__Internal")]
		unsafe int* NSMetadataItemResolutionWidthDPIKey { get; }

		// extern int *const _Nonnull NSMetadataItemResolutionHeightDPIKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemResolutionHeightDPIKey", "__Internal")]
		unsafe int* NSMetadataItemResolutionHeightDPIKey { get; }

		// extern int *const _Nonnull NSMetadataItemExposureModeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExposureModeKey", "__Internal")]
		unsafe int* NSMetadataItemExposureModeKey { get; }

		// extern int *const _Nonnull NSMetadataItemExposureTimeSecondsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExposureTimeSecondsKey", "__Internal")]
		unsafe int* NSMetadataItemExposureTimeSecondsKey { get; }

		// extern int *const _Nonnull NSMetadataItemEXIFVersionKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemEXIFVersionKey", "__Internal")]
		unsafe int* NSMetadataItemEXIFVersionKey { get; }

		// extern int *const _Nonnull NSMetadataItemCameraOwnerKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCameraOwnerKey", "__Internal")]
		unsafe int* NSMetadataItemCameraOwnerKey { get; }

		// extern int *const _Nonnull NSMetadataItemFocalLength35mmKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFocalLength35mmKey", "__Internal")]
		unsafe int* NSMetadataItemFocalLength35mmKey { get; }

		// extern int *const _Nonnull NSMetadataItemLensModelKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLensModelKey", "__Internal")]
		unsafe int* NSMetadataItemLensModelKey { get; }

		// extern int *const _Nonnull NSMetadataItemEXIFGPSVersionKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemEXIFGPSVersionKey", "__Internal")]
		unsafe int* NSMetadataItemEXIFGPSVersionKey { get; }

		// extern int *const _Nonnull NSMetadataItemAltitudeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAltitudeKey", "__Internal")]
		unsafe int* NSMetadataItemAltitudeKey { get; }

		// extern int *const _Nonnull NSMetadataItemLatitudeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLatitudeKey", "__Internal")]
		unsafe int* NSMetadataItemLatitudeKey { get; }

		// extern int *const _Nonnull NSMetadataItemLongitudeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLongitudeKey", "__Internal")]
		unsafe int* NSMetadataItemLongitudeKey { get; }

		// extern int *const _Nonnull NSMetadataItemSpeedKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemSpeedKey", "__Internal")]
		unsafe int* NSMetadataItemSpeedKey { get; }

		// extern int *const _Nonnull NSMetadataItemTimestampKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTimestampKey", "__Internal")]
		unsafe int* NSMetadataItemTimestampKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSTrackKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSTrackKey", "__Internal")]
		unsafe int* NSMetadataItemGPSTrackKey { get; }

		// extern int *const _Nonnull NSMetadataItemImageDirectionKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemImageDirectionKey", "__Internal")]
		unsafe int* NSMetadataItemImageDirectionKey { get; }

		// extern int *const _Nonnull NSMetadataItemNamedLocationKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemNamedLocationKey", "__Internal")]
		unsafe int* NSMetadataItemNamedLocationKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSStatusKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSStatusKey", "__Internal")]
		unsafe int* NSMetadataItemGPSStatusKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSMeasureModeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSMeasureModeKey", "__Internal")]
		unsafe int* NSMetadataItemGPSMeasureModeKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDOPKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDOPKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDOPKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSMapDatumKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSMapDatumKey", "__Internal")]
		unsafe int* NSMetadataItemGPSMapDatumKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDestLatitudeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDestLatitudeKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDestLatitudeKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDestLongitudeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDestLongitudeKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDestLongitudeKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDestBearingKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDestBearingKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDestBearingKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDestDistanceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDestDistanceKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDestDistanceKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSProcessingMethodKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSProcessingMethodKey", "__Internal")]
		unsafe int* NSMetadataItemGPSProcessingMethodKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSAreaInformationKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSAreaInformationKey", "__Internal")]
		unsafe int* NSMetadataItemGPSAreaInformationKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDateStampKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDateStampKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDateStampKey { get; }

		// extern int *const _Nonnull NSMetadataItemGPSDifferentalKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGPSDifferentalKey", "__Internal")]
		unsafe int* NSMetadataItemGPSDifferentalKey { get; }

		// extern int *const _Nonnull NSMetadataItemCodecsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCodecsKey", "__Internal")]
		unsafe int* NSMetadataItemCodecsKey { get; }

		// extern int *const _Nonnull NSMetadataItemMediaTypesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMediaTypesKey", "__Internal")]
		unsafe int* NSMetadataItemMediaTypesKey { get; }

		// extern int *const _Nonnull NSMetadataItemStreamableKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemStreamableKey", "__Internal")]
		unsafe int* NSMetadataItemStreamableKey { get; }

		// extern int *const _Nonnull NSMetadataItemTotalBitRateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTotalBitRateKey", "__Internal")]
		unsafe int* NSMetadataItemTotalBitRateKey { get; }

		// extern int *const _Nonnull NSMetadataItemVideoBitRateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemVideoBitRateKey", "__Internal")]
		unsafe int* NSMetadataItemVideoBitRateKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudioBitRateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudioBitRateKey", "__Internal")]
		unsafe int* NSMetadataItemAudioBitRateKey { get; }

		// extern int *const _Nonnull NSMetadataItemDeliveryTypeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDeliveryTypeKey", "__Internal")]
		unsafe int* NSMetadataItemDeliveryTypeKey { get; }

		// extern int *const _Nonnull NSMetadataItemAlbumKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAlbumKey", "__Internal")]
		unsafe int* NSMetadataItemAlbumKey { get; }

		// extern int *const _Nonnull NSMetadataItemHasAlphaChannelKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemHasAlphaChannelKey", "__Internal")]
		unsafe int* NSMetadataItemHasAlphaChannelKey { get; }

		// extern int *const _Nonnull NSMetadataItemRedEyeOnOffKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRedEyeOnOffKey", "__Internal")]
		unsafe int* NSMetadataItemRedEyeOnOffKey { get; }

		// extern int *const _Nonnull NSMetadataItemMeteringModeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMeteringModeKey", "__Internal")]
		unsafe int* NSMetadataItemMeteringModeKey { get; }

		// extern int *const _Nonnull NSMetadataItemMaxApertureKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMaxApertureKey", "__Internal")]
		unsafe int* NSMetadataItemMaxApertureKey { get; }

		// extern int *const _Nonnull NSMetadataItemFNumberKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFNumberKey", "__Internal")]
		unsafe int* NSMetadataItemFNumberKey { get; }

		// extern int *const _Nonnull NSMetadataItemExposureProgramKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExposureProgramKey", "__Internal")]
		unsafe int* NSMetadataItemExposureProgramKey { get; }

		// extern int *const _Nonnull NSMetadataItemExposureTimeStringKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExposureTimeStringKey", "__Internal")]
		unsafe int* NSMetadataItemExposureTimeStringKey { get; }

		// extern int *const _Nonnull NSMetadataItemHeadlineKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemHeadlineKey", "__Internal")]
		unsafe int* NSMetadataItemHeadlineKey { get; }

		// extern int *const _Nonnull NSMetadataItemInstructionsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemInstructionsKey", "__Internal")]
		unsafe int* NSMetadataItemInstructionsKey { get; }

		// extern int *const _Nonnull NSMetadataItemCityKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCityKey", "__Internal")]
		unsafe int* NSMetadataItemCityKey { get; }

		// extern int *const _Nonnull NSMetadataItemStateOrProvinceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemStateOrProvinceKey", "__Internal")]
		unsafe int* NSMetadataItemStateOrProvinceKey { get; }

		// extern int *const _Nonnull NSMetadataItemCountryKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCountryKey", "__Internal")]
		unsafe int* NSMetadataItemCountryKey { get; }

		// extern int *const _Nonnull NSMetadataItemTextContentKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTextContentKey", "__Internal")]
		unsafe int* NSMetadataItemTextContentKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudioSampleRateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudioSampleRateKey", "__Internal")]
		unsafe int* NSMetadataItemAudioSampleRateKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudioChannelCountKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudioChannelCountKey", "__Internal")]
		unsafe int* NSMetadataItemAudioChannelCountKey { get; }

		// extern int *const _Nonnull NSMetadataItemTempoKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTempoKey", "__Internal")]
		unsafe int* NSMetadataItemTempoKey { get; }

		// extern int *const _Nonnull NSMetadataItemKeySignatureKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemKeySignatureKey", "__Internal")]
		unsafe int* NSMetadataItemKeySignatureKey { get; }

		// extern int *const _Nonnull NSMetadataItemTimeSignatureKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemTimeSignatureKey", "__Internal")]
		unsafe int* NSMetadataItemTimeSignatureKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudioEncodingApplicationKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudioEncodingApplicationKey", "__Internal")]
		unsafe int* NSMetadataItemAudioEncodingApplicationKey { get; }

		// extern int *const _Nonnull NSMetadataItemComposerKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemComposerKey", "__Internal")]
		unsafe int* NSMetadataItemComposerKey { get; }

		// extern int *const _Nonnull NSMetadataItemLyricistKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLyricistKey", "__Internal")]
		unsafe int* NSMetadataItemLyricistKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudioTrackNumberKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudioTrackNumberKey", "__Internal")]
		unsafe int* NSMetadataItemAudioTrackNumberKey { get; }

		// extern int *const _Nonnull NSMetadataItemRecordingDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRecordingDateKey", "__Internal")]
		unsafe int* NSMetadataItemRecordingDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemMusicalGenreKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMusicalGenreKey", "__Internal")]
		unsafe int* NSMetadataItemMusicalGenreKey { get; }

		// extern int *const _Nonnull NSMetadataItemIsGeneralMIDISequenceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemIsGeneralMIDISequenceKey", "__Internal")]
		unsafe int* NSMetadataItemIsGeneralMIDISequenceKey { get; }

		// extern int *const _Nonnull NSMetadataItemRecordingYearKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRecordingYearKey", "__Internal")]
		unsafe int* NSMetadataItemRecordingYearKey { get; }

		// extern int *const _Nonnull NSMetadataItemOrganizationsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemOrganizationsKey", "__Internal")]
		unsafe int* NSMetadataItemOrganizationsKey { get; }

		// extern int *const _Nonnull NSMetadataItemLanguagesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemLanguagesKey", "__Internal")]
		unsafe int* NSMetadataItemLanguagesKey { get; }

		// extern int *const _Nonnull NSMetadataItemRightsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRightsKey", "__Internal")]
		unsafe int* NSMetadataItemRightsKey { get; }

		// extern int *const _Nonnull NSMetadataItemPublishersKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPublishersKey", "__Internal")]
		unsafe int* NSMetadataItemPublishersKey { get; }

		// extern int *const _Nonnull NSMetadataItemContributorsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemContributorsKey", "__Internal")]
		unsafe int* NSMetadataItemContributorsKey { get; }

		// extern int *const _Nonnull NSMetadataItemCoverageKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCoverageKey", "__Internal")]
		unsafe int* NSMetadataItemCoverageKey { get; }

		// extern int *const _Nonnull NSMetadataItemSubjectKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemSubjectKey", "__Internal")]
		unsafe int* NSMetadataItemSubjectKey { get; }

		// extern int *const _Nonnull NSMetadataItemThemeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemThemeKey", "__Internal")]
		unsafe int* NSMetadataItemThemeKey { get; }

		// extern int *const _Nonnull NSMetadataItemDescriptionKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDescriptionKey", "__Internal")]
		unsafe int* NSMetadataItemDescriptionKey { get; }

		// extern int *const _Nonnull NSMetadataItemIdentifierKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemIdentifierKey", "__Internal")]
		unsafe int* NSMetadataItemIdentifierKey { get; }

		// extern int *const _Nonnull NSMetadataItemAudiencesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAudiencesKey", "__Internal")]
		unsafe int* NSMetadataItemAudiencesKey { get; }

		// extern int *const _Nonnull NSMetadataItemNumberOfPagesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemNumberOfPagesKey", "__Internal")]
		unsafe int* NSMetadataItemNumberOfPagesKey { get; }

		// extern int *const _Nonnull NSMetadataItemPageWidthKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPageWidthKey", "__Internal")]
		unsafe int* NSMetadataItemPageWidthKey { get; }

		// extern int *const _Nonnull NSMetadataItemPageHeightKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPageHeightKey", "__Internal")]
		unsafe int* NSMetadataItemPageHeightKey { get; }

		// extern int *const _Nonnull NSMetadataItemSecurityMethodKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemSecurityMethodKey", "__Internal")]
		unsafe int* NSMetadataItemSecurityMethodKey { get; }

		// extern int *const _Nonnull NSMetadataItemCreatorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCreatorKey", "__Internal")]
		unsafe int* NSMetadataItemCreatorKey { get; }

		// extern int *const _Nonnull NSMetadataItemEncodingApplicationsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemEncodingApplicationsKey", "__Internal")]
		unsafe int* NSMetadataItemEncodingApplicationsKey { get; }

		// extern int *const _Nonnull NSMetadataItemDueDateKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDueDateKey", "__Internal")]
		unsafe int* NSMetadataItemDueDateKey { get; }

		// extern int *const _Nonnull NSMetadataItemStarRatingKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemStarRatingKey", "__Internal")]
		unsafe int* NSMetadataItemStarRatingKey { get; }

		// extern int *const _Nonnull NSMetadataItemPhoneNumbersKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPhoneNumbersKey", "__Internal")]
		unsafe int* NSMetadataItemPhoneNumbersKey { get; }

		// extern int *const _Nonnull NSMetadataItemEmailAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemEmailAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemEmailAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemInstantMessageAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemInstantMessageAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemInstantMessageAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemKindKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemKindKey", "__Internal")]
		unsafe int* NSMetadataItemKindKey { get; }

		// extern int *const _Nonnull NSMetadataItemRecipientsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRecipientsKey", "__Internal")]
		unsafe int* NSMetadataItemRecipientsKey { get; }

		// extern int *const _Nonnull NSMetadataItemFinderCommentKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFinderCommentKey", "__Internal")]
		unsafe int* NSMetadataItemFinderCommentKey { get; }

		// extern int *const _Nonnull NSMetadataItemFontsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemFontsKey", "__Internal")]
		unsafe int* NSMetadataItemFontsKey { get; }

		// extern int *const _Nonnull NSMetadataItemAppleLoopsRootKeyKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAppleLoopsRootKeyKey", "__Internal")]
		unsafe int* NSMetadataItemAppleLoopsRootKeyKey { get; }

		// extern int *const _Nonnull NSMetadataItemAppleLoopsKeyFilterTypeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAppleLoopsKeyFilterTypeKey", "__Internal")]
		unsafe int* NSMetadataItemAppleLoopsKeyFilterTypeKey { get; }

		// extern int *const _Nonnull NSMetadataItemAppleLoopsLoopModeKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAppleLoopsLoopModeKey", "__Internal")]
		unsafe int* NSMetadataItemAppleLoopsLoopModeKey { get; }

		// extern int *const _Nonnull NSMetadataItemAppleLoopDescriptorsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAppleLoopDescriptorsKey", "__Internal")]
		unsafe int* NSMetadataItemAppleLoopDescriptorsKey { get; }

		// extern int *const _Nonnull NSMetadataItemMusicalInstrumentCategoryKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMusicalInstrumentCategoryKey", "__Internal")]
		unsafe int* NSMetadataItemMusicalInstrumentCategoryKey { get; }

		// extern int *const _Nonnull NSMetadataItemMusicalInstrumentNameKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemMusicalInstrumentNameKey", "__Internal")]
		unsafe int* NSMetadataItemMusicalInstrumentNameKey { get; }

		// extern int *const _Nonnull NSMetadataItemCFBundleIdentifierKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemCFBundleIdentifierKey", "__Internal")]
		unsafe int* NSMetadataItemCFBundleIdentifierKey { get; }

		// extern int *const _Nonnull NSMetadataItemInformationKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemInformationKey", "__Internal")]
		unsafe int* NSMetadataItemInformationKey { get; }

		// extern int *const _Nonnull NSMetadataItemDirectorKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemDirectorKey", "__Internal")]
		unsafe int* NSMetadataItemDirectorKey { get; }

		// extern int *const _Nonnull NSMetadataItemProducerKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemProducerKey", "__Internal")]
		unsafe int* NSMetadataItemProducerKey { get; }

		// extern int *const _Nonnull NSMetadataItemGenreKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemGenreKey", "__Internal")]
		unsafe int* NSMetadataItemGenreKey { get; }

		// extern int *const _Nonnull NSMetadataItemPerformersKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemPerformersKey", "__Internal")]
		unsafe int* NSMetadataItemPerformersKey { get; }

		// extern int *const _Nonnull NSMetadataItemOriginalFormatKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemOriginalFormatKey", "__Internal")]
		unsafe int* NSMetadataItemOriginalFormatKey { get; }

		// extern int *const _Nonnull NSMetadataItemOriginalSourceKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemOriginalSourceKey", "__Internal")]
		unsafe int* NSMetadataItemOriginalSourceKey { get; }

		// extern int *const _Nonnull NSMetadataItemAuthorEmailAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAuthorEmailAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemAuthorEmailAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemRecipientEmailAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRecipientEmailAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemRecipientEmailAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemAuthorAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemAuthorAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemAuthorAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemRecipientAddressesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemRecipientAddressesKey", "__Internal")]
		unsafe int* NSMetadataItemRecipientAddressesKey { get; }

		// extern int *const _Nonnull NSMetadataItemIsLikelyJunkKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemIsLikelyJunkKey", "__Internal")]
		unsafe int* NSMetadataItemIsLikelyJunkKey { get; }

		// extern int *const _Nonnull NSMetadataItemExecutableArchitecturesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExecutableArchitecturesKey", "__Internal")]
		unsafe int* NSMetadataItemExecutableArchitecturesKey { get; }

		// extern int *const _Nonnull NSMetadataItemExecutablePlatformKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemExecutablePlatformKey", "__Internal")]
		unsafe int* NSMetadataItemExecutablePlatformKey { get; }

		// extern int *const _Nonnull NSMetadataItemApplicationCategoriesKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemApplicationCategoriesKey", "__Internal")]
		unsafe int* NSMetadataItemApplicationCategoriesKey { get; }

		// extern int *const _Nonnull NSMetadataItemIsApplicationManagedKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataItemIsApplicationManagedKey", "__Internal")]
		unsafe int* NSMetadataItemIsApplicationManagedKey { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSUInteger;
		[Field ("NSUInteger", "__Internal")]
		int NSUInteger { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const NSNotificationName _Nonnull NSMetadataQueryGatheringProgressNotification __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 4), iOS (5, 0)]
		[Field ("NSMetadataQueryGatheringProgressNotification", "__Internal")]
		unsafe int* NSMetadataQueryGatheringProgressNotification { get; }

		// extern const NSNotificationName _Nonnull NSMetadataQueryDidFinishGatheringNotification __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 4), iOS (5, 0)]
		[Field ("NSMetadataQueryDidFinishGatheringNotification", "__Internal")]
		unsafe int* NSMetadataQueryDidFinishGatheringNotification { get; }

		// extern const NSNotificationName _Nonnull NSMetadataQueryDidUpdateNotification __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 4), iOS (5, 0)]
		[Field ("NSMetadataQueryDidUpdateNotification", "__Internal")]
		unsafe int* NSMetadataQueryDidUpdateNotification { get; }

		// extern int *const _Nonnull NSMetadataQueryUpdateAddedItemsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (8, 0)]
		[Field ("NSMetadataQueryUpdateAddedItemsKey", "__Internal")]
		unsafe int* NSMetadataQueryUpdateAddedItemsKey { get; }

		// extern int *const _Nonnull NSMetadataQueryUpdateChangedItemsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (8, 0)]
		[Field ("NSMetadataQueryUpdateChangedItemsKey", "__Internal")]
		unsafe int* NSMetadataQueryUpdateChangedItemsKey { get; }

		// extern int *const _Nonnull NSMetadataQueryUpdateRemovedItemsKey __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (8, 0)]
		[Field ("NSMetadataQueryUpdateRemovedItemsKey", "__Internal")]
		unsafe int* NSMetadataQueryUpdateRemovedItemsKey { get; }

		// extern int *const _Nonnull NSMetadataQueryResultContentRelevanceAttribute __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 4), iOS (5, 0)]
		[Field ("NSMetadataQueryResultContentRelevanceAttribute", "__Internal")]
		unsafe int* NSMetadataQueryResultContentRelevanceAttribute { get; }

		// extern int *const _Nonnull NSMetadataQueryUserHomeScope __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 4)]
		[Field ("NSMetadataQueryUserHomeScope", "__Internal")]
		unsafe int* NSMetadataQueryUserHomeScope { get; }

		// extern int *const _Nonnull NSMetadataQueryLocalComputerScope __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 4)]
		[Field ("NSMetadataQueryLocalComputerScope", "__Internal")]
		unsafe int* NSMetadataQueryLocalComputerScope { get; }

		// extern int *const _Nonnull NSMetadataQueryNetworkScope __attribute__((availability(macos, introduced=10.4))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 4)]
		[Field ("NSMetadataQueryNetworkScope", "__Internal")]
		unsafe int* NSMetadataQueryNetworkScope { get; }

		// extern int *const _Nonnull NSMetadataQueryIndexedLocalComputerScope __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataQueryIndexedLocalComputerScope", "__Internal")]
		unsafe int* NSMetadataQueryIndexedLocalComputerScope { get; }

		// extern int *const _Nonnull NSMetadataQueryIndexedNetworkScope __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoWatch, NoTV, NoiOS, Mac (10, 9)]
		[Field ("NSMetadataQueryIndexedNetworkScope", "__Internal")]
		unsafe int* NSMetadataQueryIndexedNetworkScope { get; }

		// extern int *const _Nonnull NSMetadataQueryUbiquitousDocumentsScope __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataQueryUbiquitousDocumentsScope", "__Internal")]
		unsafe int* NSMetadataQueryUbiquitousDocumentsScope { get; }

		// extern int *const _Nonnull NSMetadataQueryUbiquitousDataScope __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSMetadataQueryUbiquitousDataScope", "__Internal")]
		unsafe int* NSMetadataQueryUbiquitousDataScope { get; }

		// extern int *const _Nonnull NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope", "__Internal")]
		unsafe int* NSMetadataQueryAccessibleUbiquitousExternalDocumentsScope { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int *const _Nonnull NSNetServicesErrorCode;
		[Field ("NSNetServicesErrorCode", "__Internal")]
		unsafe int* NSNetServicesErrorCode { get; }

		// extern const NSErrorDomain _Nonnull NSNetServicesErrorDomain;
		[Field ("NSNetServicesErrorDomain", "__Internal")]
		unsafe int* NSNetServicesErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSDictionary;
		[Field ("NSDictionary", "__Internal")]
		int NSDictionary { get; }

		// extern int NSData;
		[Field ("NSData", "__Internal")]
		int NSData { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int BOOL;
		[Field ("BOOL", "__Internal")]
		int BOOL { get; }

		// extern int *const _Nonnull NSUbiquitousKeyValueStoreChangeReasonKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSUbiquitousKeyValueStoreChangeReasonKey", "__Internal")]
		unsafe int* NSUbiquitousKeyValueStoreChangeReasonKey { get; }

		// extern int *const _Nonnull NSUbiquitousKeyValueStoreChangedKeysKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSUbiquitousKeyValueStoreChangedKeysKey", "__Internal")]
		unsafe int* NSUbiquitousKeyValueStoreChangedKeysKey { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int *const _Nonnull NSUndoManagerGroupIsDiscardableKey __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSUndoManagerGroupIsDiscardableKey", "__Internal")]
		unsafe int* NSUndoManagerGroupIsDiscardableKey { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern int NSString;
		[Field ("NSString", "__Internal")]
		int NSString { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerWillUndoChangeNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerWillUndoChangeNotification", "__Internal")]
		unsafe int* NSUndoManagerWillUndoChangeNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerWillRedoChangeNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerWillRedoChangeNotification", "__Internal")]
		unsafe int* NSUndoManagerWillRedoChangeNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerDidUndoChangeNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerDidUndoChangeNotification", "__Internal")]
		unsafe int* NSUndoManagerDidUndoChangeNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerDidRedoChangeNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerDidRedoChangeNotification", "__Internal")]
		unsafe int* NSUndoManagerDidRedoChangeNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerDidOpenUndoGroupNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerDidOpenUndoGroupNotification", "__Internal")]
		unsafe int* NSUndoManagerDidOpenUndoGroupNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerWillCloseUndoGroupNotification __attribute__((availability(macos, introduced=10.0))) __attribute__((availability(ios, introduced=3.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 0), iOS (3, 0)]
		[Field ("NSUndoManagerWillCloseUndoGroupNotification", "__Internal")]
		unsafe int* NSUndoManagerWillCloseUndoGroupNotification { get; }

		// extern const NSNotificationName _Nonnull NSUndoManagerDidCloseUndoGroupNotification __attribute__((availability(macos, introduced=10.7))) __attribute__((availability(ios, introduced=5.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 7), iOS (5, 0)]
		[Field ("NSUndoManagerDidCloseUndoGroupNotification", "__Internal")]
		unsafe int* NSUndoManagerDidCloseUndoGroupNotification { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const CFStringRef _Nonnull kSSLSessionConfig_default __attribute__((availability(macos, introduced=10.2, deprecated=10.13))) __attribute__((availability(ios, introduced=5.0, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_default", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_default { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_ATSv1 __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_ATSv1", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_ATSv1 { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_ATSv1_noPFS __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_ATSv1_noPFS", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_ATSv1_noPFS { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_standard __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_standard", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_standard { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_RC4_fallback __attribute__((availability(macos, introduced=10.2, deprecated=10.13))) __attribute__((availability(ios, introduced=5.0, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_RC4_fallback", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_RC4_fallback { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_TLSv1_fallback __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_TLSv1_fallback", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_TLSv1_fallback { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_TLSv1_RC4_fallback __attribute__((availability(macos, introduced=10.2, deprecated=10.13))) __attribute__((availability(ios, introduced=5.0, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_TLSv1_RC4_fallback", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_TLSv1_RC4_fallback { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_legacy __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_legacy", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_legacy { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_legacy_DHE __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_legacy_DHE", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_legacy_DHE { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_anonymous __attribute__((availability(macos, introduced=10.2, deprecated=10.15))) __attribute__((availability(ios, introduced=5.0, deprecated=13.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_anonymous", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_anonymous { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_3DES_fallback __attribute__((availability(macos, introduced=10.2, deprecated=10.13))) __attribute__((availability(ios, introduced=5.0, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_3DES_fallback", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_3DES_fallback { get; }

		// extern const CFStringRef _Nonnull kSSLSessionConfig_TLSv1_3DES_fallback __attribute__((availability(macos, introduced=10.2, deprecated=10.13))) __attribute__((availability(ios, introduced=5.0, deprecated=11.0)));
		[Introduced (PlatformName.MacOSX, 10, 2, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "No longer supported. Use Network.framework.")]
		[Introduced (PlatformName.iOS, 5, 0, message: "No longer supported. Use Network.framework.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported. Use Network.framework.")]
		[Field ("kSSLSessionConfig_TLSv1_3DES_fallback", "__Internal")]
		unsafe CFStringRef* kSSLSessionConfig_TLSv1_3DES_fallback { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int64_t NSURLSessionTransferSizeUnknown __attribute__((availability(macos, introduced=10.9))) __attribute__((availability(ios, introduced=7.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 9), iOS (7, 0)]
		[Field ("NSURLSessionTransferSizeUnknown", "__Internal")]
		long NSURLSessionTransferSizeUnknown { get; }

		// extern int NSURLSession;
		[Field ("NSURLSession", "__Internal")]
		int NSURLSession { get; }

		// extern int NSURLSession;
		[Field ("NSURLSession", "__Internal")]
		int NSURLSession { get; }

		// extern int NSURLSessionDataTask;
		[Field ("NSURLSessionDataTask", "__Internal")]
		int NSURLSessionDataTask { get; }

		// extern int NSURLSessionDataTask;
		[Field ("NSURLSessionDataTask", "__Internal")]
		int NSURLSessionDataTask { get; }

		// extern int NSURLSessionUploadTask;
		[Field ("NSURLSessionUploadTask", "__Internal")]
		int NSURLSessionUploadTask { get; }

		// extern int NSURLSessionUploadTask;
		[Field ("NSURLSessionUploadTask", "__Internal")]
		int NSURLSessionUploadTask { get; }

		// extern int NSURLSessionUploadTask;
		[Field ("NSURLSessionUploadTask", "__Internal")]
		int NSURLSessionUploadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }

		// extern int NSURLSessionStreamTask;
		[Field ("NSURLSessionStreamTask", "__Internal")]
		int NSURLSessionStreamTask { get; }

		// extern int NSURLSessionStreamTask;
		[Field ("NSURLSessionStreamTask", "__Internal")]
		int NSURLSessionStreamTask { get; }

		// extern int NSURLSessionWebSocketTask;
		[Field ("NSURLSessionWebSocketTask", "__Internal")]
		int NSURLSessionWebSocketTask { get; }

		// extern int NSURLSessionWebSocketTask;
		[Field ("NSURLSessionWebSocketTask", "__Internal")]
		int NSURLSessionWebSocketTask { get; }

		// extern int NSURLSessionWebSocketTask;
		[Field ("NSURLSessionWebSocketTask", "__Internal")]
		int NSURLSessionWebSocketTask { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int NSURLSessionDataTask;
		[Field ("NSURLSessionDataTask", "__Internal")]
		int NSURLSessionDataTask { get; }

		// extern int NSURLSessionUploadTask;
		[Field ("NSURLSessionUploadTask", "__Internal")]
		int NSURLSessionUploadTask { get; }

		// extern int NSURLSessionUploadTask;
		[Field ("NSURLSessionUploadTask", "__Internal")]
		int NSURLSessionUploadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }

		// extern int NSURLSessionDownloadTask;
		[Field ("NSURLSessionDownloadTask", "__Internal")]
		int NSURLSessionDownloadTask { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern const float NSURLSessionTaskPriorityLow __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLSessionTaskPriorityLow", "__Internal")]
		float NSURLSessionTaskPriorityLow { get; }

		// extern const float NSURLSessionTaskPriorityHigh __attribute__((availability(macos, introduced=10.10))) __attribute__((availability(ios, introduced=8.0))) __attribute__((availability(watchos, introduced=2.0))) __attribute__((availability(tvos, introduced=9.0)));
		[Watch (2, 0), TV (9, 0), Mac (10, 10), iOS (8, 0)]
		[Field ("NSURLSessionTaskPriorityHigh", "__Internal")]
		float NSURLSessionTaskPriorityHigh { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int NSURLSessionConfiguration;
		[Field ("NSURLSessionConfiguration", "__Internal")]
		int NSURLSessionConfiguration { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }

		// extern int nullable;
		[Field ("nullable", "__Internal")]
		int nullable { get; }

		// extern int id;
		[Field ("id", "__Internal")]
		int id { get; }
	}
}
