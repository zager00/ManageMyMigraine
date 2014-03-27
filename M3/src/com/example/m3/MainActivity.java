package com.example.m3;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import android.content.Context;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;



public class MainActivity extends Activity {

	
	private Button faqButton;
	private Button logButton;
	private Button historyButton;
	private Button recommendationButton;
	
	
	
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		faqButton = (Button) findViewById(R.id.buttonFAQ);
		logButton = (Button) findViewById(R.id.buttonLog);
		historyButton = (Button) findViewById(R.id.buttonHistory);
		recommendationButton = (Button) findViewById(R.id.buttonRecommendation);
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

}

