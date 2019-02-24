/* ========================================================================
 *   title          :   jquery plugins for cfg webcontrols
 *   version        :   1.0
 *   description    :   plugin based on bootstrap jquery model
 *   see            :   https://www.sitepoint.com/customizing-bootstrap-jquery-plugins/
 *                      
 * ======================================================================== */

+function ($) {
    'use strict';

    // DROPDOWN PUBLIC CLASS DEFINITION
    // ==============================
    var SelectAutoDropdown = function (element, options) {
        this.$element = $(element)
        this.options = $.extend({}, SelectAutoDropdown.DEFAULTS, options)
        this.isLoading = false
    };

    SelectAutoDropdown.VERSION = '1.0'
    SelectAutoDropdown.DEFAULTS = {

    }

	// SelectAutoDropdown STATE
    // ========================
    SelectAutoDropdown.prototype.setState = function (state) {
    }

    SelectAutoDropdown.prototype.toggle = function () {
        var selectedOption = this.$element.attr('selectedIndex');
        __doPostBack(this.$element.attr('id'), selectedOption);
    }
	

	// SelectAutoDropdown PLUGIN DEFINITION
    // ========================

    function Plugin(option) {
        return this.each(function () {
            var $this = $(this)
            var data = $this.data('.cfg-dropdown-control')
            var options = typeof option == 'object' && option

            if (!data) $this.data('.cfg-dropdown-control', (data = new SelectAutoDropdown(this, options)))

            if (option == 'toggle') data.toggle()
            else if (option) data.setState(option)
        })
    }

    var old = $.fn.selectAutoDropdown

    $.fn.selectAutoDropdown = Plugin
    $.fn.selectAutoDropdown.Constructor = SelectAutoDropdown


	// SelectAutoDropdown NO CONFLICT
    // ==================

    $.fn.selectAutoDropdown.noConflict = function () {
    	$.fn.selectAutoDropdown = old
        return this
    }

    // DATA-API
    // ===============

    $(document)
        .on('change.cfg-dropdown-control.data-api', '[data-toggle^="filter"]', function (e) {
            var $ctrl = $(e.target).closest('.cfg-dropdown-control')
            Plugin.call($ctrl, 'toggle')
            e.preventDefault()
        })
        
}(jQuery);