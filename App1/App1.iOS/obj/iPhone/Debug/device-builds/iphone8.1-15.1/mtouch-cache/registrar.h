#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CoreGraphics/CoreGraphics.h>
#import <QuartzCore/QuartzCore.h>

@class ColCell;
@class CollectionTest;
@class UIApplicationDelegate;
@class AppDelegate;
@class SyncfusionTest;
@class TestViewCell;
@class UICollectionViewDataSource;
@class App1_iOS_DataSources_BaseTestViewSource_1;
@class App1_iOS_DataSources_CustomerViewSource;
@class App1_iOS_DataSources_TestViewLayout;
@class Foundation_NSDispatcher;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class Foundation_InternalNSNotificationHandler;
@class UIKit_UIControlEventProxy;
@class UICollectionViewSource;
@class UIGestureRecognizerDelegate;
@class UIPickerViewModel;
@class UISearchBarDelegate;
@class UITableViewSource;
@class UITextFieldDelegate;
@class __NSObject_Disposer;
@class UIKit_UIBarButtonItem_Callback;
@class __UIGestureRecognizerToken;
@class __UIGestureRecognizerParameterlessToken;
@class UIKit_UIGestureRecognizer__UIGestureRecognizerDelegate;
@class __UILongPressGestureRecognizer;
@class __UITapGestureRecognizer;
@class __UIPinchGestureRecognizer;
@class __UISwipeGestureRecognizer;
@class UIKit_UISearchBar__UISearchBarDelegate;
@class UIKit_UITextField__UITextFieldDelegate;
@class UIKit_UIScrollView__UIScrollViewDelegate;
@class UIKit_UITextView__UITextViewDelegate;
@class C1_iOS_Grid_GridIncrementalLoadingCell;
@class C1_iOS_Core_C1Border;
@class C1_iOS_Grid_GridCellView;
@class C1_iOS_Grid_GridFreezingSeparator;
@class C1_iOS_Core_C1TransparentView;
@class C1_iOS_Grid_GridRowColumnView;
@class C1_iOS_Grid_GridDisplacedRowColumnView;
@class C1_iOS_Grid_GridSelectionLayer;
@class C1_iOS_Core_C1TextField;
@class C1_iOS_Input_C1TextBox;
@class C1_iOS_Grid_FilterEntry;
@class C1_iOS_Grid_DetailProviderRowHeaderCell;
@class C1_iOS_Grid_GridBase;
@class C1_iOS_Grid_GridColumnHeaderCell;
@class C1_iOS_Grid_GridGroupRowCell;
@class FlexGrid;
@class C1_iOS_Grid_GridCellsPanel;
@class C1_iOS_Grid_GridManipulationLayer;
@class C1_iOS_Core_ScrollViewerRootView;
@class C1_iOS_Core_C1Label;
@class C1_iOS_Core_C1RefreshControl;
@class C1_iOS_Core_C1Icon;
@class C1CompositeIcon;
@class C1FontIcon;
@class C1_iOS_Core_C1VectorIcon;
@class C1PathIcon;
@class C1PolygonIcon;
@class C1BitmapIcon;
@class C1_iOS_Core_C1ScrollViewer;
@class C1CheckBox;
@class C1_iOS_Core_C1ToggleButton;
@class C1_iOS_Core_UIPickerViewStringArrayModel;
@class C1_iOS_Core_C1DragHelper_UIManipulationRecognizer;
@class C1_iOS_Core_C1TapHelper_UIManipulationRecognizer;
@class C1_iOS_Input_KeyboardShiftingHandlerTextFieldDelegate;
@class C1_iOS_Input_ComboBoxHeaderViewDelegate;
@class C1_iOS_Input_AutoCompleteHeaderViewDelegate;
@class C1_iOS_Input_ComboBoxEditableHeaderViewDelegate;
@class C1_iOS_Input_AutoCompleteEditableHeaderViewDelegate;
@class C1_iOS_Input_RoundRectLayer;
@class C1_iOS_Input_MaskElement;
@class C1_iOS_Input_TapGestureDelegate;
@class C1_iOS_Input_ComboBoxHeaderView;
@class C1_iOS_Input_ComboBoxEditableHeaderView;
@class C1_iOS_Input_ComboBoxDropDownView;
@class C1_iOS_DataCollection_C1TableViewSource_1;
@class C1_iOS_Input_TableViewSource;
@class C1_iOS_Input_AutoCompleteHeaderView_AutoCompleteEditableHeaderView;
@class C1_iOS_Input_AutoCompleteHeaderView;
@class C1MaskedTextField;
@class C1_iOS_Input_MaskTextFieldDelegate;
@class C1DropDown;
@class C1_iOS_Input_DropDownView;
@class C1ComboBox;
@class C1AutoComplete;
@class C1_iOS_DataCollection_C1ActivityIndicatorCell;
@class C1_iOS_DataCollection_C1ActivityIndicatorLayoutAttributes;
@class C1_iOS_DataCollection_C1CollectionViewSourceHeaderCell;
@class C1_iOS_DataCollection_C1CollectionViewFlowLayout;
@class C1_iOS_DataCollection_C1CollectionViewSource_1;

@interface ColCell : UICollectionViewCell {
}
	@property (nonatomic, assign) UILabel * TitleLabel;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UILabel *) TitleLabel;
	-(void) setTitleLabel:(UILabel *)p0;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface CollectionTest : UIViewController {
}
	@property (nonatomic, assign) UICollectionView * CollectionView;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UICollectionView *) CollectionView;
	-(void) setCollectionView:(UICollectionView *)p0;
	-(void) viewDidLoad;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate, UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface SyncfusionTest : UIViewController {
}
	@property (nonatomic, assign) id FlexGridView;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(id) FlexGridView;
	-(void) setFlexGridView:(id)p0;
	-(void) viewDidLoad;
	-(void) viewDidLayoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface TestViewCell : UICollectionViewCell {
}
	@property (nonatomic, assign) UILabel * Title;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UILabel *) Title;
	-(void) setTitle:(UILabel *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UICollectionViewDataSource : NSObject<UICollectionViewDataSource> {
}
	-(id) init;
@end

@interface App1_iOS_DataSources_BaseTestViewSource_1 : NSObject<UICollectionViewDataSource> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSInteger) collectionView:(UICollectionView *)p0 numberOfItemsInSection:(NSInteger)p1;
	-(NSInteger) numberOfSectionsInCollectionView:(UICollectionView *)p0;
	-(UICollectionViewCell *) collectionView:(UICollectionView *)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface App1_iOS_DataSources_CustomerViewSource : App1_iOS_DataSources_BaseTestViewSource_1<UICollectionViewDataSource> {
}
	-(UICollectionViewCell *) collectionView:(UICollectionView *)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
@end

@interface App1_iOS_DataSources_TestViewLayout : UICollectionViewLayout {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) prepareLayout;
	-(BOOL) shouldInvalidateLayoutForBoundsChange:(CGRect)p0;
	-(CGSize) collectionViewContentSize;
	-(UICollectionViewLayoutAttributes *) layoutAttributesForItemAtIndexPath:(NSIndexPath *)p0;
	-(NSArray *) layoutAttributesForElementsInRect:(CGRect)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface UICollectionViewSource : NSObject<UICollectionViewDataSource, UIScrollViewDelegate, UICollectionViewDelegate> {
}
	-(id) init;
@end

@interface UIGestureRecognizerDelegate : NSObject<UIGestureRecognizerDelegate> {
}
	-(id) init;
@end

@interface UIPickerViewModel : NSObject<UIPickerViewDataSource, UIPickerViewDelegate> {
}
	-(id) init;
@end

@interface UISearchBarDelegate : NSObject<UISearchBarDelegate, UIBarPositioningDelegate, UIBarPositioningDelegate, UIBarPositioningDelegate> {
}
	-(id) init;
@end

@interface UITableViewSource : NSObject<UIScrollViewDelegate> {
}
	-(id) init;
@end

@interface UITextFieldDelegate : NSObject<UITextFieldDelegate> {
}
	-(id) init;
@end

@interface __UIGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface __UIGestureRecognizerParameterlessToken : __UIGestureRecognizerToken {
}
	-(void) target;
@end

@interface C1_iOS_Grid_GridIncrementalLoadingCell : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Core_C1Border : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) didMoveToSuperview;
	-(void) invalidateIntrinsicContentSize;
	-(CGSize) intrinsicContentSize;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) setNeedsLayout;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Grid_GridCellView : C1_iOS_Core_C1Border {
}
	-(id) init;
@end

@interface C1_iOS_Core_C1TextField : UITextField {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGRect) textRectForBounds:(CGRect)p0;
	-(CGRect) editingRectForBounds:(CGRect)p0;
	-(NSArray *) keyCommands;
	-(void) OnKeyDown:(UIKeyCommand *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Input_C1TextBox : C1_iOS_Core_C1TextField {
}
	-(NSString *) text;
	-(void) setText:(NSString *)p0;
	-(BOOL) resignFirstResponder;
	-(void) layoutSubviews;
	-(id) init;
@end

@interface C1_iOS_Grid_DetailProviderRowHeaderCell : C1_iOS_Core_C1Border {
}
	-(id) init;
@end

@interface C1_iOS_Grid_GridBase : UIView {
}
	@property (nonatomic, assign) BOOL IsReadOnly;
	@property (nonatomic, assign) int SelectionMode;
	@property (nonatomic, assign) int HeadersVisibility;
	@property (nonatomic, assign) int AllowResizing;
	@property (nonatomic, assign) int AllowDragging;
	@property (nonatomic, assign) BOOL AllowRefreshing;
	@property (nonatomic, assign) int AllowMerging;
	@property (nonatomic, assign) int FrozenRows;
	@property (nonatomic, assign) int FrozenColumns;
	@property (nonatomic, assign) int GridLinesVisibility;
	@property (nonatomic, assign) int ColumnHeaderGridLinesVisibility;
	@property (nonatomic, assign) int RowHeaderGridLinesVisibility;
	@property (nonatomic, assign) int TopLeftHeaderGridLinesVisibility;
	@property (nonatomic, assign) UIColor * BorderColor;
	@property (nonatomic, assign) double BorderWidth;
	@property (nonatomic, assign) UIColor * GridLinesColor;
	@property (nonatomic, assign) UIColor * HeaderGridLinesColor;
	@property (nonatomic, assign) double GridLinesWidth;
	@property (nonatomic, assign) BOOL IsAnimated;
	@property (nonatomic, assign) UIColor * RowBackgroundColor;
	@property (nonatomic, assign) UIColor * RowTextColor;
	@property (nonatomic, assign) UIColor * RowHeaderBackgroundColor;
	@property (nonatomic, assign) UIColor * ColumnHeaderBackgroundColor;
	@property (nonatomic, assign) UIColor * CursorBackgroundColor;
	@property (nonatomic, assign) UIColor * CursorTextColor;
	@property (nonatomic, assign) UIColor * SelectionBackgroundColor;
	@property (nonatomic, assign) UIColor * SelectionTextColor;
	@property (nonatomic, assign) UIColor * SelectionAdornerColor;
	@property (nonatomic, assign) UIColor * SelectionAdornerBorderColor;
	@property (nonatomic, assign) UIColor * TextColor;
	@property (nonatomic, assign) UIColor * ColumnHeaderTextColor;
	@property (nonatomic, assign) UIColor * RowHeaderTextColor;
	@property (nonatomic, assign) UIColor * EditorBackgroundColor;
	@property (nonatomic, assign) UIColor * EditorTextColor;
	@property (nonatomic, assign) UIColor * TopLeftCellBackgroundColor;
	@property (nonatomic, assign) UIColor * RowHeaderSelectedBackgroundColor;
	@property (nonatomic, assign) UIColor * ColumnHeaderSelectedBackgroundColor;
	@property (nonatomic, assign) UIColor * RowHeaderSelectedTextColor;
	@property (nonatomic, assign) UIColor * ColumnHeaderSelectedTextColor;
	@property (nonatomic, assign) BOOL ShowMarquee;
	@property (nonatomic, assign) BOOL ShowSelectionMenu;
	@property (nonatomic, assign) int KeyActionTab;
	@property (nonatomic, assign) int KeyActionEnter;
	@property (nonatomic, assign) int ZoomMode;
	@property (nonatomic, assign) int HeadersGridLinesVisibility;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) IsReadOnly;
	-(void) setIsReadOnly:(BOOL)p0;
	-(int) SelectionMode;
	-(void) setSelectionMode:(int)p0;
	-(int) HeadersVisibility;
	-(void) setHeadersVisibility:(int)p0;
	-(int) AllowResizing;
	-(void) setAllowResizing:(int)p0;
	-(int) AllowDragging;
	-(void) setAllowDragging:(int)p0;
	-(BOOL) AllowRefreshing;
	-(void) setAllowRefreshing:(BOOL)p0;
	-(int) AllowMerging;
	-(void) setAllowMerging:(int)p0;
	-(int) FrozenRows;
	-(void) setFrozenRows:(int)p0;
	-(int) FrozenColumns;
	-(void) setFrozenColumns:(int)p0;
	-(int) GridLinesVisibility;
	-(void) setGridLinesVisibility:(int)p0;
	-(int) ColumnHeaderGridLinesVisibility;
	-(void) setColumnHeaderGridLinesVisibility:(int)p0;
	-(int) RowHeaderGridLinesVisibility;
	-(void) setRowHeaderGridLinesVisibility:(int)p0;
	-(int) TopLeftHeaderGridLinesVisibility;
	-(void) setTopLeftHeaderGridLinesVisibility:(int)p0;
	-(UIColor *) BorderColor;
	-(void) setBorderColor:(UIColor *)p0;
	-(double) BorderWidth;
	-(void) setBorderWidth:(double)p0;
	-(UIColor *) GridLinesColor;
	-(void) setGridLinesColor:(UIColor *)p0;
	-(UIColor *) HeaderGridLinesColor;
	-(void) setHeaderGridLinesColor:(UIColor *)p0;
	-(double) GridLinesWidth;
	-(void) setGridLinesWidth:(double)p0;
	-(BOOL) IsAnimated;
	-(void) setIsAnimated:(BOOL)p0;
	-(UIColor *) RowBackgroundColor;
	-(void) setRowBackgroundColor:(UIColor *)p0;
	-(UIColor *) RowTextColor;
	-(void) setRowTextColor:(UIColor *)p0;
	-(UIColor *) RowHeaderBackgroundColor;
	-(void) setRowHeaderBackgroundColor:(UIColor *)p0;
	-(UIColor *) ColumnHeaderBackgroundColor;
	-(void) setColumnHeaderBackgroundColor:(UIColor *)p0;
	-(UIColor *) CursorBackgroundColor;
	-(void) setCursorBackgroundColor:(UIColor *)p0;
	-(UIColor *) CursorTextColor;
	-(void) setCursorTextColor:(UIColor *)p0;
	-(UIColor *) SelectionBackgroundColor;
	-(void) setSelectionBackgroundColor:(UIColor *)p0;
	-(UIColor *) SelectionTextColor;
	-(void) setSelectionTextColor:(UIColor *)p0;
	-(UIColor *) SelectionAdornerColor;
	-(void) setSelectionAdornerColor:(UIColor *)p0;
	-(UIColor *) SelectionAdornerBorderColor;
	-(void) setSelectionAdornerBorderColor:(UIColor *)p0;
	-(UIColor *) TextColor;
	-(void) setTextColor:(UIColor *)p0;
	-(UIColor *) ColumnHeaderTextColor;
	-(void) setColumnHeaderTextColor:(UIColor *)p0;
	-(UIColor *) RowHeaderTextColor;
	-(void) setRowHeaderTextColor:(UIColor *)p0;
	-(UIColor *) EditorBackgroundColor;
	-(void) setEditorBackgroundColor:(UIColor *)p0;
	-(UIColor *) EditorTextColor;
	-(void) setEditorTextColor:(UIColor *)p0;
	-(UIColor *) TopLeftCellBackgroundColor;
	-(void) setTopLeftCellBackgroundColor:(UIColor *)p0;
	-(UIColor *) RowHeaderSelectedBackgroundColor;
	-(void) setRowHeaderSelectedBackgroundColor:(UIColor *)p0;
	-(UIColor *) ColumnHeaderSelectedBackgroundColor;
	-(void) setColumnHeaderSelectedBackgroundColor:(UIColor *)p0;
	-(UIColor *) RowHeaderSelectedTextColor;
	-(void) setRowHeaderSelectedTextColor:(UIColor *)p0;
	-(UIColor *) ColumnHeaderSelectedTextColor;
	-(void) setColumnHeaderSelectedTextColor:(UIColor *)p0;
	-(BOOL) ShowMarquee;
	-(void) setShowMarquee:(BOOL)p0;
	-(BOOL) ShowSelectionMenu;
	-(void) setShowSelectionMenu:(BOOL)p0;
	-(int) KeyActionTab;
	-(void) setKeyActionTab:(int)p0;
	-(int) KeyActionEnter;
	-(void) setKeyActionEnter:(int)p0;
	-(int) ZoomMode;
	-(void) setZoomMode:(int)p0;
	-(int) HeadersGridLinesVisibility;
	-(void) setHeadersGridLinesVisibility:(int)p0;
	-(void) didMoveToWindow;
	-(CGSize) intrinsicContentSize;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) layoutSubviews;
	-(BOOL) canBecomeFirstResponder;
	-(NSArray *) keyCommands;
	-(BOOL) canPerformAction:(SEL)p0 withSender:(NSObject *)p1;
	-(void) selectAll:(NSObject *)p0;
	-(void) cut:(NSObject *)p0;
	-(void) copy:(NSObject *)p0;
	-(void) paste:(NSObject *)p0;
	-(void) OnKeyDown:(UIKeyCommand *)p0;
	-(void) menuAction0:(UIKeyCommand *)p0;
	-(void) menuAction1:(UIKeyCommand *)p0;
	-(void) menuAction2:(UIKeyCommand *)p0;
	-(void) menuAction3:(UIKeyCommand *)p0;
	-(void) menuAction4:(UIKeyCommand *)p0;
	-(void) menuAction5:(UIKeyCommand *)p0;
	-(void) menuAction6:(UIKeyCommand *)p0;
	-(void) menuAction7:(UIKeyCommand *)p0;
	-(void) menuAction8:(UIKeyCommand *)p0;
	-(void) menuAction9:(UIKeyCommand *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Grid_GridColumnHeaderCell : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGSize) intrinsicContentSize;
	-(void) layoutSubviews;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Grid_GridGroupRowCell : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface FlexGrid : C1_iOS_Grid_GridBase {
}
	@property (nonatomic, assign) BOOL AutoGenerateColumns;
	@property (nonatomic, assign) double MinColumnWidth;
	@property (nonatomic, assign) double MaxColumnWidth;
	@property (nonatomic, assign) double MinRowHeight;
	@property (nonatomic, assign) double MaxRowHeight;
	@property (nonatomic, assign) BOOL AllowSorting;
	@property (nonatomic, assign) BOOL ShowSort;
	@property (nonatomic, assign) double TreeIndent;
	@property (nonatomic, assign) UIColor * AlternatingRowBackgroundColor;
	@property (nonatomic, assign) UIColor * AlternatingRowTextColor;
	@property (nonatomic, assign) UIColor * GroupRowBackgroundColor;
	@property (nonatomic, assign) UIColor * GroupRowTextColor;
	@property (nonatomic, assign) UIColor * NewRowBackgroundColor;
	@property (nonatomic, assign) UIColor * NewRowTextColor;
	@property (nonatomic, assign) BOOL ShowOutlineBar;
	@property (nonatomic, assign) int GroupRowPosition;
	@property (nonatomic, assign) int NewRowPosition;
	@property (nonatomic, assign) NSString * NewRowPlaceholder;
	@property (nonatomic, assign) int SortIconPosition;
	@property (nonatomic, assign) int Style;
	-(BOOL) AutoGenerateColumns;
	-(void) setAutoGenerateColumns:(BOOL)p0;
	-(double) MinColumnWidth;
	-(void) setMinColumnWidth:(double)p0;
	-(double) MaxColumnWidth;
	-(void) setMaxColumnWidth:(double)p0;
	-(double) MinRowHeight;
	-(void) setMinRowHeight:(double)p0;
	-(double) MaxRowHeight;
	-(void) setMaxRowHeight:(double)p0;
	-(BOOL) AllowSorting;
	-(void) setAllowSorting:(BOOL)p0;
	-(BOOL) ShowSort;
	-(void) setShowSort:(BOOL)p0;
	-(double) TreeIndent;
	-(void) setTreeIndent:(double)p0;
	-(UIColor *) AlternatingRowBackgroundColor;
	-(void) setAlternatingRowBackgroundColor:(UIColor *)p0;
	-(UIColor *) AlternatingRowTextColor;
	-(void) setAlternatingRowTextColor:(UIColor *)p0;
	-(UIColor *) GroupRowBackgroundColor;
	-(void) setGroupRowBackgroundColor:(UIColor *)p0;
	-(UIColor *) GroupRowTextColor;
	-(void) setGroupRowTextColor:(UIColor *)p0;
	-(UIColor *) NewRowBackgroundColor;
	-(void) setNewRowBackgroundColor:(UIColor *)p0;
	-(UIColor *) NewRowTextColor;
	-(void) setNewRowTextColor:(UIColor *)p0;
	-(BOOL) ShowOutlineBar;
	-(void) setShowOutlineBar:(BOOL)p0;
	-(int) GroupRowPosition;
	-(void) setGroupRowPosition:(int)p0;
	-(int) NewRowPosition;
	-(void) setNewRowPosition:(int)p0;
	-(NSString *) NewRowPlaceholder;
	-(void) setNewRowPlaceholder:(NSString *)p0;
	-(int) SortIconPosition;
	-(void) setSortIconPosition:(int)p0;
	-(int) Style;
	-(void) setStyle:(int)p0;
	-(id) init;
@end

@interface C1_iOS_Grid_GridCellsPanel : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGSize) intrinsicContentSize;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface C1_iOS_Core_C1Label : UILabel {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGSize) intrinsicContentSize;
	-(void) drawTextInRect:(CGRect)p0;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Core_C1Icon : UIView {
}
	@property (nonatomic, assign) UIColor * Color;
	@property (nonatomic, assign) UIEdgeInsets Padding;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIColor *) Color;
	-(void) setColor:(UIColor *)p0;
	-(UIEdgeInsets) Padding;
	-(void) setPadding:(UIEdgeInsets)p0;
	-(void) didMoveToSuperview;
	-(CGSize) intrinsicContentSize;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1CompositeIcon : C1_iOS_Core_C1Icon {
}
	-(void) layoutSubviews;
	-(id) init;
@end

@interface C1FontIcon : C1_iOS_Core_C1Icon {
}
	@property (nonatomic, assign) NSString * Text;
	@property (nonatomic, assign) NSString * FontFamily;
	@property (nonatomic, assign) double FontSize;
	-(NSString *) Text;
	-(void) setText:(NSString *)p0;
	-(NSString *) FontFamily;
	-(void) setFontFamily:(NSString *)p0;
	-(double) FontSize;
	-(void) setFontSize:(double)p0;
	-(void) layoutSubviews;
	-(void) drawRect:(CGRect)p0;
	-(id) init;
@end

@interface C1_iOS_Core_C1VectorIcon : C1_iOS_Core_C1Icon {
}
	@property (nonatomic, assign) CGRect ViewBox;
	@property (nonatomic, assign) double StrokeThickness;
	@property (nonatomic, assign) UIColor * StrokeColor;
	-(CGRect) ViewBox;
	-(void) setViewBox:(CGRect)p0;
	-(double) StrokeThickness;
	-(void) setStrokeThickness:(double)p0;
	-(UIColor *) StrokeColor;
	-(void) setStrokeColor:(UIColor *)p0;
	-(void) layoutSublayersOfLayer:(CALayer *)p0;
	-(id) init;
@end

@interface C1PathIcon : C1_iOS_Core_C1VectorIcon {
}
	@property (nonatomic, assign) NSString * Data;
	-(NSString *) Data;
	-(void) setData:(NSString *)p0;
	-(id) init;
@end

@interface C1PolygonIcon : C1_iOS_Core_C1VectorIcon {
}
	@property (nonatomic, assign) BOOL IsClosed;
	-(BOOL) IsClosed;
	-(void) setIsClosed:(BOOL)p0;
	-(id) init;
@end

@interface C1BitmapIcon : C1_iOS_Core_C1Icon {
}
	@property (nonatomic, assign) UIImage * Source;
	@property (nonatomic, assign) BOOL ShowAsMonochrome;
	-(UIImage *) Source;
	-(void) setSource:(UIImage *)p0;
	-(BOOL) ShowAsMonochrome;
	-(void) setShowAsMonochrome:(BOOL)p0;
	-(void) layoutSubviews;
	-(void) drawRect:(CGRect)p0;
	-(id) init;
@end

@interface C1_iOS_Core_C1ScrollViewer : UIScrollView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) didMoveToSuperview;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) setNeedsLayout;
	-(void) layoutSubviews;
	-(void) scrollRectToVisible:(CGRect)p0 animated:(BOOL)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1CheckBox : UIView {
}
	@property (nonatomic, assign) BOOL IsThreeState;
	@property (nonatomic, assign) BOOL IsEnabled;
	@property (nonatomic, assign) BOOL IsReadOnly;
	@property (nonatomic, assign) UIColor * Color;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) IsThreeState;
	-(void) setIsThreeState:(BOOL)p0;
	-(BOOL) IsEnabled;
	-(void) setIsEnabled:(BOOL)p0;
	-(BOOL) IsReadOnly;
	-(void) setIsReadOnly:(BOOL)p0;
	-(UIColor *) Color;
	-(void) setColor:(UIColor *)p0;
	-(void) didMoveToSuperview;
	-(CGSize) intrinsicContentSize;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Core_C1ToggleButton : UIView {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(CGSize) intrinsicContentSize;
	-(void) layoutSubviews;
	-(CGSize) sizeThatFits:(CGSize)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_Input_RoundRectLayer : CAShapeLayer {
}
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) needsDisplayOnBoundsChange;
	-(void) setNeedsDisplayOnBoundsChange:(BOOL)p0;
	-(void) layoutSublayers;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_DataCollection_C1TableViewSource_1 : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSInteger) numberOfSectionsInTableView:(UITableView *)p0;
	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1;
	-(NSString *) tableView:(UITableView *)p0 titleForHeaderInSection:(NSInteger)p1;
	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface C1MaskedTextField : C1_iOS_Core_C1TextField {
}
	@property (nonatomic, assign) NSString * Mask;
	@property (nonatomic, assign) UIColor * PlaceholderColor;
	@property (nonatomic, assign) signed short PromptChar;
	@property (nonatomic, assign) int FlowDirection;
	@property (nonatomic, assign, readonly) BOOL MaskCompleted;
	@property (nonatomic, assign) BOOL ShowClearButton;
	@property (nonatomic, assign) NSString * Value;
	@property (nonatomic, assign) UIEdgeInsets Padding;
	-(NSString *) Mask;
	-(void) setMask:(NSString *)p0;
	-(UIColor *) PlaceholderColor;
	-(void) setPlaceholderColor:(UIColor *)p0;
	-(signed short) PromptChar;
	-(void) setPromptChar:(signed short)p0;
	-(int) FlowDirection;
	-(void) setFlowDirection:(int)p0;
	-(BOOL) MaskCompleted;
	-(BOOL) ShowClearButton;
	-(void) setShowClearButton:(BOOL)p0;
	-(NSString *) Value;
	-(void) setValue:(NSString *)p0;
	-(UIEdgeInsets) Padding;
	-(void) setPadding:(UIEdgeInsets)p0;
	-(void) awakeFromNib;
	-(void) setText:(NSString *)p0;
	-(NSString *) text;
	-(NSString *) placeholder;
	-(void) setPlaceholder:(NSString *)p0;
	-(void) setKeyboardType:(NSInteger)p0;
	-(NSInteger) keyboardType;
	-(void) setSecureTextEntry:(BOOL)p0;
	-(BOOL) isSecureTextEntry;
	-(void) setTextAlignment:(NSInteger)p0;
	-(NSInteger) textAlignment;
	-(void) layoutSubviews;
	-(void) cut:(NSObject *)p0;
	-(void) drawPlaceholderInRect:(CGRect)p0;
	-(id) init;
@end

@interface C1DropDown : UIView {
}
	@property (nonatomic, assign) UIColor * ButtonBackgroundColor;
	@property (nonatomic, assign) UIView * DropDown;
	@property (nonatomic, assign) UIColor * HeaderBackgroundColor;
	@property (nonatomic, assign) UIColor * EditableHeaderBackgroundColor;
	@property (nonatomic, assign) double HeaderBorderWidth;
	@property (nonatomic, assign) int FlowDirection;
	@property (nonatomic, assign) BOOL ShowButton;
	@property (nonatomic, assign) BOOL IsEnabled;
	@property (nonatomic, assign) UIColor * HeaderBorderColor;
	@property (nonatomic, assign) UIView * Header;
	@property (nonatomic, assign) UIView * EditableHeader;
	@property (nonatomic, assign) BOOL IsEditable;
	@property (nonatomic, assign) BOOL IsAnimated;
	@property (nonatomic, assign) int DropDownMode;
	@property (nonatomic, assign) UIColor * DropDownBackgroundColor;
	@property (nonatomic, assign) UIColor * DropDownBorderColor;
	@property (nonatomic, assign) double DropDownBorderWidth;
	@property (nonatomic, assign) UIColor * ButtonColor;
	@property (nonatomic, assign) UIColor * CloseButtonTextColor;
	@property (nonatomic, assign) UIColor * CloseButtonBackgroundColor;
	@property (nonatomic, assign) BOOL IsDropDownOpen;
	@property (nonatomic, assign) double DropDownHeight;
	@property (nonatomic, assign) double DropDownWidth;
	@property (nonatomic, assign) double MaxDropDownHeight;
	@property (nonatomic, assign) double MinDropDownHeight;
	@property (nonatomic, assign) int DropDownBehavior;
	@property (nonatomic, assign) BOOL AutoClose;
	@property (nonatomic, assign) BOOL ShowHeader;
	@property (nonatomic, assign) BOOL ShowEditableHeader;
	@property (nonatomic, assign) BOOL ShowCloseButton;
	@property (nonatomic, assign) BOOL ShowClearButton;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(UIColor *) ButtonBackgroundColor;
	-(void) setButtonBackgroundColor:(UIColor *)p0;
	-(UIView *) DropDown;
	-(void) setDropDown:(UIView *)p0;
	-(UIColor *) HeaderBackgroundColor;
	-(void) setHeaderBackgroundColor:(UIColor *)p0;
	-(UIColor *) EditableHeaderBackgroundColor;
	-(void) setEditableHeaderBackgroundColor:(UIColor *)p0;
	-(double) HeaderBorderWidth;
	-(void) setHeaderBorderWidth:(double)p0;
	-(int) FlowDirection;
	-(void) setFlowDirection:(int)p0;
	-(BOOL) ShowButton;
	-(void) setShowButton:(BOOL)p0;
	-(BOOL) IsEnabled;
	-(void) setIsEnabled:(BOOL)p0;
	-(UIColor *) HeaderBorderColor;
	-(void) setHeaderBorderColor:(UIColor *)p0;
	-(UIView *) Header;
	-(void) setHeader:(UIView *)p0;
	-(UIView *) EditableHeader;
	-(void) setEditableHeader:(UIView *)p0;
	-(BOOL) IsEditable;
	-(void) setIsEditable:(BOOL)p0;
	-(BOOL) IsAnimated;
	-(void) setIsAnimated:(BOOL)p0;
	-(int) DropDownMode;
	-(void) setDropDownMode:(int)p0;
	-(UIColor *) DropDownBackgroundColor;
	-(void) setDropDownBackgroundColor:(UIColor *)p0;
	-(UIColor *) DropDownBorderColor;
	-(void) setDropDownBorderColor:(UIColor *)p0;
	-(double) DropDownBorderWidth;
	-(void) setDropDownBorderWidth:(double)p0;
	-(UIColor *) ButtonColor;
	-(void) setButtonColor:(UIColor *)p0;
	-(UIColor *) CloseButtonTextColor;
	-(void) setCloseButtonTextColor:(UIColor *)p0;
	-(UIColor *) CloseButtonBackgroundColor;
	-(void) setCloseButtonBackgroundColor:(UIColor *)p0;
	-(BOOL) IsDropDownOpen;
	-(void) setIsDropDownOpen:(BOOL)p0;
	-(double) DropDownHeight;
	-(void) setDropDownHeight:(double)p0;
	-(double) DropDownWidth;
	-(void) setDropDownWidth:(double)p0;
	-(double) MaxDropDownHeight;
	-(void) setMaxDropDownHeight:(double)p0;
	-(double) MinDropDownHeight;
	-(void) setMinDropDownHeight:(double)p0;
	-(int) DropDownBehavior;
	-(void) setDropDownBehavior:(int)p0;
	-(BOOL) AutoClose;
	-(void) setAutoClose:(BOOL)p0;
	-(BOOL) ShowHeader;
	-(void) setShowHeader:(BOOL)p0;
	-(BOOL) ShowEditableHeader;
	-(void) setShowEditableHeader:(BOOL)p0;
	-(BOOL) ShowCloseButton;
	-(void) setShowCloseButton:(BOOL)p0;
	-(BOOL) ShowClearButton;
	-(void) setShowClearButton:(BOOL)p0;
	-(void) didMoveToSuperview;
	-(BOOL) isHidden;
	-(void) setHidden:(BOOL)p0;
	-(void) RespondToOrientationChanged;
	-(void) RespondToFocuseChanged;
	-(void) OnTapped:(UITapGestureRecognizer *)p0;
	-(void) OnHeaderTapped:(UITapGestureRecognizer *)p0;
	-(UIView *) hitTest:(CGPoint)p0 withEvent:(UIEvent *)p1;
	-(void) willMoveToWindow:(UIWindow *)p0;
	-(void) layoutSubviews;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1ComboBox : C1DropDown {
}
	-(void) didMoveToSuperview;
	-(id) init;
@end

@interface C1AutoComplete : C1ComboBox {
}
	@property (nonatomic, assign) int AutoCompleteMode;
	-(int) AutoCompleteMode;
	-(void) setAutoCompleteMode:(int)p0;
	-(id) init;
@end

@interface C1_iOS_DataCollection_C1CollectionViewFlowLayout : UICollectionViewFlowLayout {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) prepareLayout;
	-(CGSize) collectionViewContentSize;
	-(NSArray *) layoutAttributesForElementsInRect:(CGRect)p0;
	-(UICollectionViewLayoutAttributes *) layoutAttributesForDecorationViewOfKind:(NSString *)p0 atIndexPath:(NSIndexPath *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface C1_iOS_DataCollection_C1CollectionViewSource_1 : NSObject<UICollectionViewDelegate, UICollectionViewDataSource, UIScrollViewDelegate, UICollectionViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSInteger) numberOfSectionsInCollectionView:(UICollectionView *)p0;
	-(NSInteger) collectionView:(UICollectionView *)p0 numberOfItemsInSection:(NSInteger)p1;
	-(UICollectionViewCell *) collectionView:(UICollectionView *)p0 cellForItemAtIndexPath:(NSIndexPath *)p1;
	-(UICollectionReusableView *) collectionView:(UICollectionView *)p0 viewForSupplementaryElementOfKind:(NSString *)p1 atIndexPath:(NSIndexPath *)p2;
	-(void) scrollViewDidScroll:(UIScrollView *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


