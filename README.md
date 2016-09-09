# ASP .NET MVC Core Bootstrap Tag Helpers #

ASP.NET Core MVC Bootstrap tag helpers. This package includes tag helpers for the following bootstrap components:

- Alert 
- Badge 
- Breadcrumb 
- Button 
- Carousel 
- Collapse 
- DropDown 
- Input 
- Jumbotron 
- Label 
- ListGroup 
- Media 
- Modal 
- NavBar 
- PageHeader 
- Pagination 
- Panel 
- Popover 
- ProgressBar 
- Tabs 
- Thumbnail 
- Tooltip 
- Well 

## Installation ##

* Create a new ASP .NET Core Web Application.
* Install the Tag Helpers. To install ASP.NET Core MVC Bootstrap Tag Helpers, run the following command in the Package Manager Console
`Install-Package jQWidgets.AspNetCore.Mvc.Bootstrap.TagHelpers`.
* Update `_ViewImports.cshtml`.

    ```html
    @using jQWidgets.AspNetCore.Mvc.Bootstrap.Demos
    @using jQWidgets.AspNetCore.Mvc.Bootstrap.TagHelpers
    @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
    @addTagHelper *, jQWidgets.AspNetCore.Mvc.Bootstrap.TagHelpers
    @inject Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration TelemetryConfiguration
    ```
    
* Add a reference to `bootstrap.mvc.css` in `_Layout.cshtml`. `bootstrap.mvc.css` is included in this repository.
    
    ```html
    <environment names="Development">
        <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
        <link rel="stylesheet" href="~/css/bootstrap.mvc.css" />
        <link rel="stylesheet" href="~/css/site.css" />
    </environment>
    ```
    
* Build the Solution.
* Add a Bootstrap Tag Helper to a Page.
## Modal ##

To create a Bootstrap Modal, add the following Tag Helper:


```html
<bootstrap-modal id="myModal" aria-labelledby="myModalLabel" size="sm">
    <bootstrap-modal-header>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
            <span aria-hidden="true">&times;</span>
        </button>
        <h4 class="modal-title">Sample modal header</h4>
    </bootstrap-modal-header>
    <bootstrap-modal-body>
        Sample modal body
    </bootstrap-modal-body>
</bootstrap-modal>
```


To open the modal from a button, add the bootstrap-toggle-modal attribute to the button with the id of the modal as value:
```html
<bootstrap-button type="button" class="btn btn-primary" bootstrap-toggle-modal="myModal">
    Open sample modal
</bootstrap-button>
```

***Related Tag Helpers:***

* `<bootstrap-modal-header>` - denotes the Modal's header section.
* `<bootstrap-modal-body>` - denotes the Modal's content section.
* `<bootstrap-modal-footer>` - denotes the Modal's footer section.

***Applicable attributes:***

Animation can be added to the Modal by adding the class "fade" to it.
* data-backdrop - true (default)/false/"static" - includes a modal-backdrop element. Specify "static" for a backdrop which doesn't close the modal on click.
* data-keyboard - true (default)/false - closes the modal when escape key is pressed.
* data-show - true (default)/false - shows the modal when initialized.
* size - "xs"/"sm"/"lg". If size is not set, the size of the widget will be normal.

***Methods:***
```javascript
$().modal('toggle')
$().modal('show')
$().modal('hide')
$().modal('handleUpdate')
```
***Events:***
```javascript
show.bs.modal
shown.bs.modal
hide.bs.modal
hidden.bs.modal
loaded.bs.modal
```
## Dropdown ##

To create a Bootstrap Dropdown, add the following Tag Helper:

```html
<bootstrap-dropdown>
    <bootstrap-dropdown-label id="newDropDown" class="btn btn-danger btn-lg" content="DropDown Button"></bootstrap-dropdown-label>
    <bootstrap-dropdown-menu labelledby="newDropDown">
        <bootstrap-dropdown-menu-item><a href="#">Action</a></bootstrap-dropdown-menu-item>
        <bootstrap-dropdown-menu-item><a href="#">Another action</a></bootstrap-dropdown-menu-item>
        <bootstrap-dropdown-menu-item><a href="#">Something else here</a></bootstrap-dropdown-menu-item>
        <bootstrap-dropdown-menu-separator></bootstrap-dropdown-menu-separator>
        <bootstrap-dropdown-menu-item><a href="#">Separated link</a></bootstrap-dropdown-menu-item>
    </bootstrap-dropdown-menu>
</bootstrap-dropdown>
```

You can add more Dropdown options by inserting more <bootstrap-dropdown-menu-item> Tag Helpers.

**Related Tag Helpers:**

* `<bootstrap-dropdown-label>` - denotes the Dropdown's label (button). Its content can be set via the content attribute.
* `<bootstrap-dropdown-menu>` - denotes the container (popup) for the Dropdown's items. It has a labelledby attribute that should be set to the id of the <bootstrap-dropdown-label> to denote connection between them.
* `<bootstrap-dropdown-menu-item>` - denotes a Dropdown item.
* `<bootstrap-dropdown-menu-separator>` - denotes a separator between Dropdown items.


***Methods:***
```javascript
$().dropdown('toggle')
```
***Events:***
* show.bs.dropdown
* shown.bs.dropdown
* hide.bs.dropdown
* hidden.bs.dropdown

## Tab ##

To create a Bootstrap togglable Tab, add the following Tag Helper:

```html
<bootstrap-tabs>
    <bootstrap-tabs-nav id="tabs3" class="">
        <bootstrap-tab active="true"><a href="#home" aria-controls="home" role="tab">Home</a></bootstrap-tab>
        <bootstrap-tab><a href="#profile" aria-controls="profile" role="tab">Profile</a></bootstrap-tab>
        <bootstrap-tab>
            <bootstrap-dropdown>
                <bootstrap-dropdown-label id="bootstrapDropdown" class="btn btn-link" content="Dropdown"></bootstrap-dropdown-label>
                <bootstrap-dropdown-menu labelledby="bootstrapDropdown">
                    <bootstrap-dropdown-menu-item><a href="#dropdown1">fat</a></bootstrap-dropdown-menu-item>
                    <bootstrap-dropdown-menu-item><a href="#dropdown2">mdo</a></bootstrap-dropdown-menu-item>
                </bootstrap-dropdown-menu>
            </bootstrap-dropdown>
        </bootstrap-tab>
    </bootstrap-tabs-nav>
    <bootstrap-tabs-content>
        <bootstrap-tab-pane active="true" id="home" class="fade in">Content 1.</bootstrap-tab-pane>
        <bootstrap-tab-pane id="profile" class="fade">Content 2.</bootstrap-tab-pane>
        <bootstrap-tab-pane id="dropdown1" class="fade">Content 3.</bootstrap-tab-pane>
        <bootstrap-tab-pane id="dropdown2" class="fade">Content 4.</bootstrap-tab-pane>
    </bootstrap-tabs-content>
</bootstrap-tabs>
````

To add more tabs to this sample Tab, insert <bootstrap-tab> Tag Helpers in `<bootstrap-tabs-nav>` and `<bootstrap-tab-pane>` Tag Helpers to `<bootstrap-tabs-content>`. These act as tab header and tab content sections respectively.

***Related Tag Helpers:***
* <bootstrap-tabs-nav> - denotes the Tab's header section.
* <bootstrap-tab> - denotes a Tab's tab in the header section. The attribute active denotes if the tab is selected.
* <bootstrap-tabs-content> - denotes the Tab's content section.
* <bootstrap-tab-pane> - denotes a Tab's content panel in the content section. The attribute active denotes if the content panel is visible. If the class "fade" is added, selection animation will be enabled.

***Methods:***
```javascript
$().tab('show')
```
***Events:***
```javascript
hide.bs.tab
show.bs.tab
hidden.bs.tab
shown.bs.tab
```
## Tooltip ##

To create a Bootstrap Tooltip, add the attribute bootstrap-tooltip to an existing tag or Tag Helper. The value of the attribute specifies the tooltip's content. Supported tags are: `<div>, <img>, <span>, <nav>, <button>, <a>, <p>, <h1>, <h2>, <h3>, <h4>, <h5> and <h6>`


`<bootstrap-button bootstrap-tooltip-toggle="btn2" bootstrap-tooltip="Tooltip on the top" type="button" id="btn2" class="btn btn-default" data-placement='top'>Tooltip on top</bootstrap-button>`


***Applicable attributes:***
* data-animation - true (default)/false - apply a CSS fade transition to the tooltip.
* data-container - string/false - appends the tooltip to a specific element. Example: data-container="body".
* data-delay - number/object - delay showing and hiding the tooltip (ms) - does not apply to manual trigger type. If a number is supplied, delay is applied to both hide/show. Object structure is: delay: { "show": 500, "hide": 100 }.
* data-html - true/false (default) - insert HTML into the tooltip. If false, jQuery's text method will be used to insert content into the DOM. Use text if you're worried about XSS attacks.
* data-placement - "top" (default)/"left"/"right"/"bottom"/"auto"/function - sets the tooltip's position relative to the host element. When "auto" is specified, it will dynamically reorient the tooltip. For example, if placement is "auto left", the tooltip will display to the left when possible, otherwise it will display right. When a function is used to determine the placement, it is called with the tooltip DOM node as its first argument and the triggering element DOM node as its second. The this context is set to the tooltip instance.
* data-selector - string/false (default) - if a selector is provided, tooltip objects will be delegated to the specified targets. In practice, this is used to enable dynamic HTML content to have tooltips added.
* data-trigger - "click"/"hover"/"focus"/"manual" (default is "hover focus") - how tooltip is triggered. You may pass multiple triggers; separate them with a space. "manual" cannot be combined with any other trigger.
* data-viewport - string/object/function (default is { selector: 'body', padding: 0 }) - keeps the tooltip within the bounds of this element. Example: viewport: '#viewport' or { "selector": "#viewport", "padding": 0 }. If a function is given, it is called with the triggering element DOM node as its only argument. The this context is set to the tooltip instance.

***Methods:***
```javascript
$().tooltip('show')
$().tooltip('hide')
$().tooltipal('toggle')
$().tooltip('destroy')
```
***Events:***
```javascript
show.bs.tooltip
shown.bs.tooltip
hide.bs.tooltip
hidden.bs.tooltip
inserted.bs.tooltip
```
## Popover ##

To create a Bootstrap Popover, add the attribute bootstrap-popover to an existing tag or Tag Helper. Supported tags are: `<div>, <img>, <span>, <nav>, <button>, <a>, <p>, <h1>, <h2>, <h3>, <h4>, <h5> and <h6>`

```javascript
<bootstrap-button bootstrap-popover="popover1b" type="button" id="myButton1b" class="btn btn-lg btn-danger" data-placement='right' title="Popover title" data-content="And here's some amazing content.">`
    Click to toggle popover
</bootstrap-button>
```

***Applicable attributes:***
* data-animation - true (default)/false - apply a CSS fade transition to the popover.
* data-container - string/false - appends the popover to a specific element. Example: data-container="body".
* data-content - string (default is "")/function - sets the popover's content. If a function is given, it will be called with its this reference set to the element that the popover is attached to.
* data-delay - number/object - delay showing and hiding the popover (ms) - does not apply to manual trigger type. If a number is supplied, delay is applied to both hide/show. Object structure is: delay: { "show": 500, "hide": 100 }.
* data-html - true/false (default) - insert HTML into the popover. If false, jQuery's text method will be used to insert content into the DOM. Use text if you're worried about XSS attacks.
* data-placement - "top" (default)/"left"/"right"/"bottom"/"auto"/function - sets the popover's position relative to the host element. When "auto" is specified, it will dynamically reorient the popover. For example, if placement is "auto left", the popover will display to the left when possible, otherwise it will display right. When a function is used to determine the placement, it is called with the popover DOM node as its first argument and the triggering element DOM node as its second. The this context is set to the popover instance.
* data-selector - string/false (default) - if a selector is provided, popover objects will be delegated to the specified targets. In practice, this is used to enable dynamic HTML content to have tooltips added.
* data-title (alternative to title) - string (default is "")/function - sets the popover's title. If a function is given, it will be called with its this reference set to the element that the popover is attached to.
* data-trigger - "click"/"hover"/"focus"/"manual" (default is "hover focus") - how popover is triggered. You may pass multiple triggers; separate them with a space. "manual" cannot be combined with any other trigger.
* data-viewport - string/object/function (default is { selector: 'body', padding: 0 }) - keeps the popover within the bounds of this element. Example: viewport: '#viewport' or { "selector": "#viewport", "padding": 0 }. If a function is given, it is called with the triggering element DOM node as its only argument. The this context is set to the popover instance.
* title (alternative to data-title) - string (default is "")/function - sets the popover's title. If a function is given, it will be called with its this reference set to the element that the popover is attached to.

***Methods:***
```javascript
$().popover(show)
$().popover(hide)
$().popover(toggle)
$().popover(destroy)
```
***Events:***
```javascript
show.bs.popover
shown.bs.popover
hide.bs.popover
hidden.bs.popover
inserted.bs.popover
```
## Alert ##

To create a Bootstrap Alert, add the following Tag Helper:

```html
<bootstrap-alert class="alert-danger alert-dismissible fade in">
    <bootstrap-alert-close><span aria-hidden="true">×</span></bootstrap-alert-close>
    <strong>Holy guacamole!</strong> Best check yo self, you're not looking too good.
</bootstrap-alert>
```
***Related Tag Helpers:***

`<bootstrap-alert-close>` - denotes the Alert's close button.

***Applicable attributes:***

*  The color scheme of the Alert can be changed by adding the class "alert-success", "alert-info", "alert-warning" or "alert-danger".
*  To denote that the Alert can be closed, add the "alert-dismissible" class.
*  Enable animation by adding the classes "fade", "in" and/or "out". 

***Methods:***
```javascript
$().alert('close')
```
***Events:***
```javascript
close.bs.alert
closed.bs.alert
```
## Button ##

To create a Bootstrap Button, add the following Tag Helper:
```html
<button type='button' class='btn btn-default' data-placement="top">Bootstrap Button</button>
```

***Related Tag Helpers:***

`<bootstrap-button-group>` - enclose several <bootstrap-button> Tag Helpers in this Tag Helper to create a button group.

***Applicable attributes:***
* autocomplete - set this attribute to "off" for cross-browser compatibility.
* data-toggle - "button" (for a single button)/"buttons" (for a button group).
* The class "active" has to be applied to pre-toggled buttons. To change the button's color scheme (template), add the class "btn-default", "btn-primary", "btn-success", "btn-info", "btn-warning", "btn-danger" or "btn-link".

***Methods:***
```javascript
$().button('toggle')
$().button('reset')
```
## Collapse ##

To create a Bootstrap Collapse, add the following Tag Helper:

```html
<bootstrap-collapse trigger="#triggerA, #triggerB, #triggerBB" id="collapseExample">
    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident.
</bootstrap-collapse>
```

***Applicable attributes:***
* data-parent - false (default)/selector - if a selector is provided, then all collapsible elements under the specified parent will be closed when this collapsible item is shown.
* data-toggle - toggles the collapsible element on invocation.
* trigger - selector - denotes the element that toggles the Collapse.

***Methods:***
```javascript
$().collapse('toggle')
$().collapse('show')
$().collapse('hide')
```
***Events:***
```javascript
show.bs.collapse
shown.bs.collapse
hide.bs.collapse
hidden.bs.collapse
```
## Carousel ##

To create a Bootstrap Carousel, add the following Tag Helper:

```html
<bootstrap-carousel class="slide" id="carousel-example-generic1" style="width:900px; display:block;">
    <bootstrap-carousel-indicators style="display:block;">
        <bootstrap-carousel-indicator target="#carousel-example-generic1" slide-to="0" active="true" class=""></bootstrap-carousel-indicator>
        <bootstrap-carousel-indicator target="#carousel-example-generic1" slide-to="1"></bootstrap-carousel-indicator>
        <bootstrap-carousel-indicator target="#carousel-example-generic1" slide-to="2"></bootstrap-carousel-indicator>
    </bootstrap-carousel-indicators>
    <bootstrap-carousel-items style="display:block;">
        <bootstrap-carousel-item active="true"><img src="..." /></bootstrap-carousel-item>
        <bootstrap-carousel-item><img src="..." /></bootstrap-carousel-item>
        <bootstrap-carousel-item><img src="..." /></bootstrap-carousel-item>
    </bootstrap-carousel-items>
    <bootstrap-carousel-control type="left" slide="prev" target="#carousel-example-generic1">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span> 
        <span class="sr-only">Previous</span>
    </bootstrap-carousel-control>
    <bootstrap-carousel-control type="right" slide="next" target="#carousel-example-generic1">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span> 
        <span class="sr-only">Next</span> 
    </bootstrap-carousel-control>
</bootstrap-carousel>
```

***Related Tag Helpers:***

* `<bootstrap-carousel-indicators>` - denotes the container of Carousel's indicators.
* `<bootstrap-carousel-indicator>` - denotes a Carousel indicator. Applicable attributes:
◦active - denotes the initially selected indicator.
◦target - has to be set to the selector of the Carousel that the indicator controls.

* `<bootstrap-carousel-items` - denotes the container of Carousel's items.
* `<bootstrap-carousel-item` - denotes a Carousel item. Its active attribute denotes the initially shown item.
* `<bootstrap-carousel-caption` - specifies a Carousel item's caption.
* `<bootstrap-carousel-control` - denotes a Carousel control arrow. 
    * Applicable attributes:
        * slide - specifies which item to go to when the arrow is clicked ("prev"/"next").
        * target - has to be set to the selector of the Carousel that the arrow controls.
        * type - specifies the position of the arrow ("left"/"right").


***Applicable attributes:***
* Animation can be added to the Carousel by adding the class "slide" to it.
* data-interval - number (default 5000)/false - the amount of time to delay between automatically cycling an item. If false, carousel will not automatically cycle.
* data-pause - string (default "hover") - pauses the cycling of the carousel on mouseenter and resumes the cycling of the carousel on mouseleave.
* data-wrap - true (default)/false - whether the carousel should cycle continuously or have hard stops.
* data-keyboard - true (default)/false - whether the carousel should react to keyboard events.

***Methods:***
```javascript
$().carousel('cycle')
$().carousel('pause')
$().carousel(number) number (pass it to the .carousel() function)
$().carousel('prev')
$().carousel('next')
```
***Events:***
slide.bs.carousel
slid.bs.carousel

Other Bootstrap Components

## Input group ##

To create a Bootstrap Input group, add the following Tag Helper:
```html
<bootstrap-input-group>
    <bootstrap-input-group-addon id="basic-addon">https://example.com/users/</bootstrap-input-group-addon>
    <input type="text" class="form-control" id="basic-url" aria-describedby="basic-addon">
</bootstrap-input-group>
```

***Applicable classes:***
* input-group-sm, input-group-lg 

***Related Tag Helpers:***
* <bootstrap-input-group-addon> - denotes an Input group addon.

To denote that the input and the <bootstrap-input-group-addon> Tag Helper in the Input group are connected, set the input's "aria-describedby" attribute to the id of the addon.

## Nav ##

To create a Bootstrap Nav, add the following Tag Helper:
```html
<bootstrap-nav>
    <bootstrap-nav-item class="active"><a href="#">Home</a></bootstrap-nav-item>
    <bootstrap-nav-item><a href="#">Profile</a></bootstrap-nav-item>
    <bootstrap-nav-item><a href="#">Messages</a></bootstrap-nav-item>
</bootstrap-nav>
```

***Applicable classes:***
* `nav-tabs` (alternative to "nav-pills"), nav-pills (alternative to "nav-tabs"), nav-justified, "nav-stacked 

***Related Tag Helpers:***
*  <bootstrap-nav-item> - denotes a Nav item.
Applicable classes: active - if added, the item will be initially selected, disabled - if added, the item selection will be disabled. 

## Navbar ##

To create a Bootstrap Navbar, add the following Tag Helper:

```html
<bootstrap-nav-bar>
    <bootstrap-nav-bar-header>
        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </button>
        <a class="navbar-brand" href="#">Brand</a>
    </bootstrap-nav-bar-header>
    <bootstrap-nav-bar-collapse>
        <p class="navbar-text">Signed in as Mark Otto</p>
    </bootstrap-nav-bar-collapse>
</bootstrap-nav-bar>
```

***Applicable classes:***
* navbar-inverse - applies an inverted color scheme to the Navbar. 

***Related Tag Helpers:***
* `<bootstrap-nav-bar-header>` - denotes the Navbar header.
* `<bootstrap-nav-bar-collapse>` - denotes the Navbar collapse.

Classes applicable to Navbar inner elements:
navbar-brand, navbar-toggle, navbar-form, navbar-left - aligns element to the left of the Navbar, navbar-right - aligns element to the right of the Navbar, navbar-btn, navbar-text 
## Breadcrumbs ##

To create a Bootstrap Breadcrumbs, add the following Tag Helper:

```html
<bootstrap-breadcrumb>
    <bootstrap-breadcrumb-item><a href="#">Home</a></bootstrap-breadcrumb-item>
    <bootstrap-breadcrumb-item><a href="#">Library</a></bootstrap-breadcrumb-item>
    <bootstrap-breadcrumb-item class="active">Data</bootstrap-breadcrumb-item>
</bootstrap-breadcrumb>
```

***Related Tag Helpers:***
* `<bootstrap-breadcrumb-item>` - denotes a Breadcrumb (item). 
Applicable classes: pagination-sm - if added, the item will be highlighted. 

## Pagination ##

To create a Bootstrap Pagination, add the following Tag Helper:
```html
<bootstrap-pagination>
    <bootstrap-pagination-item>
        <a href="#" aria-label="Previous"><span aria-hidden="true">&laquo;</span></a>
    </bootstrap-pagination-item>
    <bootstrap-pagination-item><a href="#">1</a></bootstrap-pagination-item>
    <bootstrap-pagination-item><a href="#">2</a></bootstrap-pagination-item>
    <bootstrap-pagination-item><a href="#">3</a></bootstrap-pagination-item>
    <bootstrap-pagination-item><a href="#">4</a></bootstrap-pagination-item>
    <bootstrap-pagination-item><a href="#">5</a></bootstrap-pagination-item>
    <bootstrap-pagination-item>
        <a href="#" aria-label="Next"><span aria-hidden="true">&raquo;</span></a>
    </bootstrap-pagination-item>
</bootstrap-pagination>
```

***Applicable classes:***
* pagination-sm, pagination-lg 

***Applicable attributes:***
* "type" - if set to "pager", denotes only a pager with "previous" and "next" links.

***Related Tag Helpers:***
* `<bootstrap-pagination-item`> - denotes a Pagination item.
Applicable classes: active, disabled, previous, next 

## Label ##

To create a Bootstrap Label, add the following Tag Helper:

```html
<bootstrap-label class="label-default">New</bootstrap-label>
```

***Applicable classes***
* label-default, label-primary, label-success, label-info, label-warning, label-danger 
## Badge ##

To create a Bootstrap Badge, add the following Tag Helper:

```html
<bootstrap-badge>42</bootstrap-badge>
```

## Jumbotron ##

To create a Bootstrap Jumbotron, add the following Tag Helper:

```html
<bootstrap-jumbotron>
    <h1>Hello, world!</h1>
    <p>This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
    <p><a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a></p>
</bootstrap-jumbotron>
```

## Page header ##

To create a Bootstrap Page header, add the following Tag Helper:
```html
<bootstrap-page-header>
    <h1>Example page header <small>Subtext for header</small></h1>
</bootstrap-page-header>
```

## Thumbnail ##

To create a Bootstrap Thumbnail, add the following Tag Helper:

```html
<bootstrap-thumbnail>
    <img src="..." style="width: 100%;" alt="illustration" />
    <div class="caption">
        <h3>Thumbnail label</h3>
        <p>...</p>
        <p>
            <bootstrap-button element="a" href="#" type="button" class="btn btn-primary" autocomplete="off">Button</bootstrap-button>
            <bootstrap-button element="a" href="#" type="button" class="btn btn-default" autocomplete="off">Button</bootstrap-button>
        </p>
    </div>
</bootstrap-thumbnail>
```

***Applicable attributes:***
* "href" (optional)
* "target" (optional)

## Progress bar ##

To create a Bootstrap Progress bar, add the following Tag Helper:

```html
<bootstrap-progress>
    <bootstrap-progress-bar value="60">
        60%
    </bootstrap-progress-bar>
</bootstrap-progress>
```

***Related Tag Helpers:***
* <bootstrap-progress-bar> - denotes a progress bar.
Applicable classes: active - enables animation (requires "progress-bar-striped"), progress-bar-success, progress-bar-info, progress-bar-warning, progress-bar-danger, progress-bar-striped 
Applicable attributes:
◦"value"
◦"minwidth"


## Media object ##

To create a Bootstrap Media object, add the following Tag Helper:

```html
<bootstrap-media>
    <bootstrap-media-left class="media-top">
        <a href="#"> 
            <img class="media-object" alt="64x64" style="width: 64px; height: 64px;" src="..." data-holder-rendered="true" />
        </a>
    </bootstrap-media-left>
    <bootstrap-media-body>
        <h4 class="media-heading">Top aligned media</h4>
        <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante.</p>
        <p>Donec sed odio dui. Nullam quis risus eget urna mollis ornare vel eu leo.</p>
    </bootstrap-media-body>
</bootstrap-media>
```

***Related Tag Helpers:***
* `<bootstrap-media-left>`

***Applicable classes:***

* media-top, media-middle, media-middle 
* `<bootstrap-media-body>`
* `<bootstrap-media-right>`

***Applicable classes:***

media-top, media-middle, media-middle 
•<bootstrap-media-list>* - wrap nested <bootstrap-media> Tag Helpers inside this Tag Helper to create a "nested list"-like structure of media objects.

The class "media-heading" should be applied to heading tags inside <bootstrap-media-body>. The class "media-object" should be applied to images inside <bootstrap-media-left> and <bootstrap-media-right>.

## List group ##

To create a Bootstrap List group, add the following Tag Helper:

```html
<bootstrap-listgroup>
    <bootstrap-listgroup-item>Cras justo odio</bootstrap-listgroup-item>
    <bootstrap-listgroup-item>Dapibus ac facilisis in</bootstrap-listgroup-item>
    <bootstrap-listgroup-item>Morbi leo risus</bootstrap-listgroup-item>
    <bootstrap-listgroup-item>Porta ac consectetur ac</bootstrap-listgroup-item>
</bootstrap-listgroup>
```

***Related Tag Helpers:***
* <bootstrap-listgroup-item> - denotes a List group item. 
***Applicable classes:*** 
* active - if added, the item will be highlighted
* disabled - if added, the item will have a disabled visual effect, 
* list-group-item-success
* list-group-item-info
* list-group-item-warning
* list-group-item-danger 
* list-group-item-success 

## Panel ##

To create a Bootstrap Panel, add the following Tag Helper:

```html
<bootstrap-panel class="panel-default">
    <bootstrap-panel-header>
        <h3 class="panel-title">Panel title</h3>
    </bootstrap-panel-header>
    <bootstrap-panel-body>
        Panel content
    </bootstrap-panel-body>
    <bootstrap-panel-footer>Panel footer</bootstrap-panel-footer>
</bootstrap-panel>
```

***Applicable classes:***
* panel-default
* panel-primary
* panel-success
* panel-info
* panel-warning
* panel-danger 

***Related Tag Helpers:***
* `<bootstrap-panel-header>` - denotes the header section of the Panel.
* `<bootstrap-panel-body>` - denotes the content section of the Panel.
* `<bootstrap-panel-footer>` - denotes the footer section of the Panel.

## Responsive embed ##

To create a Bootstrap Responsive embed, add the class "bootstrap-embed-responsive" to an iframe, embed, object or video element:

```html
<iframe bootstrap-embed-responsive="16by9" src="//www.youtube.com/embed/zpOULjyy-n8?rel=0"></iframe>
```

## Well ##

To create a Bootstrap Well, add the following Tag Helper:
```html
<bootstrap-well>Look, I'm in a well!</bootstrap-well>
```
***Applicable classes:***
* well-sm
* well-lg 

