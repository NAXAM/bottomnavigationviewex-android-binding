# Xamarin Android Binding Library
Xamarin.Android Binding Library for [Ittianyu BottomNavigationViewEx](https://github.com/ittianyu/BottomNavigationViewEx)

```
Install-Package Naxam.Ittianyu.BottomNavExtension
```

## Features ##

|Method|Description
|---|---|
|enableAnimation|Enable or disable click item animation(text scale and icon move animation in no item shifting mode). Default true.
|enableItemShiftingMode|Enable the shifting mode for each item. It will has a shift animation for item if true. Otherwise the item text always be shown. Default true when item count > 3.
|enableShiftingMode|Enable the shifting mode for navigation. It will has a shift animation if true. Otherwise all items are the same width. Default true when item count > 3.
|getBottomNavigationItemView|Get private mButton in mMenuView at position
|getBottomNavigationItemViews|Get private mButtons in mMenuView
|getCurrentItem|Get the current checked item position.
|getIconAt|Get icon at position.
|getItemCount|Get item count.
|getItemHeight|Get item height.
|getLargeLabelAt|Get large label at position. Each item has tow label, one is large, another is small.
|getSmallLabelAt|Get small label at position. Each item has tow label, one is large, another is small.
|getMenuItemPosition|Get menu item position in menu. Return position if success, -1 otherwise.
|getOnNavigationItemSelectedListener|Get OnNavigationItemSelectedListener.
|setCurrentItem|Set the current checked item.
|setIconSize|Set all item ImageView size.
|setIconSizeAt|Set all item ImageView size which at position.
|setIconVisibility|Change the visibility of icon.
|setItemHeight|Set menu item height.
|setLargeTextSize|Set all item large TextView size. Each item has tow label, one is large, another is small. Small one will be shown when item state is normal. Large one will be shown when item checked.
|setSmallTextSize|Set all item small TextView size. Each item has tow label, one is large, another is small. Small one will be shown when item state is normal. Large one will be shown when item checked.
|setTextSize|Set all item large and small TextView size.
|setTextVisibility|Change the visibility of text.
|setTypeface|set Typeface for all item TextView.
|setupWithViewPager|This method will link the given ViewPager and this BottomNavigationViewEx together so that changes in one are automatically reflected in the other. This includes scroll state changes and clicks.


## Example ##

**Style**

![](/read_me_images/normal.gif)

![](/read_me_images/no_animation.gif)

![](/read_me_images/no_shifting_mode.gif)

![](/read_me_images/no_item_shifting_mode.gif)

![](/read_me_images/no_text.gif)

![](/read_me_images/no_icon.gif)

![](/read_me_images/no_animation_shifting_mode.gif)

![](/read_me_images/no_animation_item_shifting_mode.gif)

![](/read_me_images/no_animation_shifting_mode_item_shifting_mode.gif)

![](/read_me_images/no_shifting_mode_item_shifting_mode_text.gif)

![](/read_me_images/no_animation_shifting_mode_item_shifting_mode_text.gif)

![](/read_me_images/no_shifting_mode_item_shifting_mode_and_icon.gif)

![](/read_me_images/no_item_shifting_mode_icon.gif)

![](/read_me_images/no_animation_shifting_mode_item_shifting_mode_icon.gif)

![](/read_me_images/with_padding.jpg)

![](/read_me_images/center_icon_only.gif)

![](/read_me_images/smaller_text.jpg)

![](/read_me_images/bigger_icon.jpg)

![](/read_me_images/custom_typeface.jpg)

![](/read_me_images/icon_selector_1.jpg) ![](/read_me_images/icon_selector_2.jpg)

**With ViewPager**

![](/read_me_images/with_view_pager.gif)

**Add ViewBadger**

![](/read_me_images/view_badger.gif)

## Adding to project ##

### Sdk Version ###
`compileSdkVersion` >= 25

## Getting started ##

Adding a custom widget in `xml` :
```xml
<com.ittianyu.bottomnavigationviewex.BottomNavigationViewEx
    android:id="@+id/bnve"
    android:layout_width="match_parent"
    android:layout_height="wrap_content"
    android:layout_alignParentBottom="true"
    android:background="@color/colorPrimary"
    app:itemIconTint="@color/selector_item_color"
    app:itemTextColor="@color/selector_item_color"
    app:menu="@menu/menu_navigation_with_view_pager" />
```

Binding view in `Activity`:
```java
BottomNavigationViewEx bnve = FindViewById<BottomNavigationViewEx>(Resource.Id.bnve);
```

#### Disable all animations ####
```java
bnve.enableAnimation(false);
bnve.enableShiftingMode(false);
bnve.enableItemShiftingMode(false);
```

#### Custom text and icon size ####
```java
bnve.setIconSize(widthDp, heightDp);
bnve.setTextSize(sp);
```

#### Binding with ViewPager ####
```java
// set adapter
adapter = new VpAdapter(getSupportFragmentManager(), fragments);
bind.vp.setAdapter(adapter);

// binding with ViewPager
bind.bnve.setupWithViewPager(bind.vp);
```

#### Other usage in BottomNavigationViewEx ####
You can see the demo.

#### Usage in BottomNavigationView ####
Other usage is the same as official `BottomNavigationView`.
You can [click here](https://developer.android.com/reference/android/support/design/widget/BottomNavigationView.html) for detail.

## ProGuard ##

If you are using ProGuard you might need to add the following option:
```
-keep public class android.support.design.widget.BottomNavigationView { *; }
-keep public class android.support.design.internal.BottomNavigationMenuView { *; }
-keep public class android.support.design.internal.BottomNavigationPresenter { *; }
-keep public class android.support.design.internal.BottomNavigationItemView { *; }
```

## References ##

The lib is based on `BottomNavigationView` in `Support Library 25 design`.

I found it was inflexible when I try in demo. For example, I can't change the current checked item by code. So I write a class extends it to provide some useful method.

You no need to worry about stability. Because I minimise modifying by reflecting.

## Thanks ##

- [Ittianyu](https://github.com/ittianyu)

## License ##

	MIT License
	
	Copyright (c) 2019 NAXAM
	
	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:
	
	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.
	
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
