﻿//# sourceURL=wisej.web.ext.DevExtremeWidget.dxDropDownButton.js

///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

/**
 * Process the options map before it is used to
 * create or update the widget.
 */
this.filterOptions = function (options) {

    if (options.onItemClick)
        options.onItemClick = this.initFunction(options.onItemClick);

    if (options.onButtonClick)
        options.onButtonClick = this.initFunction(options.onButtonClick);
};


// Returns a data map that can be converted to JSON.
this.filterEventData = function (args) {
	switch (args.type) {

		case "itemClick":
			return {
				itemData: args.itemData
			};

		case "buttonClick":
			return {
				selectedItem: args.selectedItem
			};
	}
};
