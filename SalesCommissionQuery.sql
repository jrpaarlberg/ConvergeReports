	Select *
	-- sales_rep_assoc_id ,
	-- sales_rep_assoc_nbr ,
	--sales_rep_assoc_nm ,
	-- cust_id, 
	-- cust_nbr, 
	--cust_nm ,
	-- cust_grp_nbr,
	--sales_ord_id ,
	--sales_ord_line_nbr ,
	--item_initial_purchase_dt ,
	--ship_id ,
	--sales_inv_id ,
	-- item_nbr ,
	--item_desc ,
	--cust_item_yrs ,
	-- sales_dt ,
	--sales_item_cost ,
	--sales_item_price ,
	--sales_markup_pct * 100 as sales_markup_pct ,
	--sales_comm_pct * 100 as sales_comm_pct ,
	-- sales_cost ,
	--sales_price ,
	-- sales_item_qty ,
	-- sales_comm_am 

FROM         dwh_sales_detail 
	WHERE
		 ((item_commodity_cd <> 'TL' ) or (item_commodity_cd is null))
		
		
