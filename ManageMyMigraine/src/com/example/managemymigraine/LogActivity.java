package com.example.managemymigraine;

import java.util.ArrayList;
import java.util.List;


import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.Toast;

public class LogActivity extends Activity {
	

	  private Spinner spinnerPain, spinnerCaffeine, spinnerSleep, spinnerActivity, spinnerEmotion, spinnerStress;
	  private Button btnSubmit;
	
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_log_data);
		
		addItemsOnSpinner();
		addListenerOnSubmit();
	}


	private void addItemsOnSpinner() {
		// TODO Auto-generated method stub
		spinnerPain = (Spinner) findViewById(R.id.spinnerPain);
		spinnerCaffeine = (Spinner) findViewById(R.id.spinnerCaffeine);
		spinnerSleep = (Spinner) findViewById(R.id.spinnerSleep);
		spinnerActivity = (Spinner) findViewById(R.id.spinnerActivity);
		spinnerEmotion = (Spinner) findViewById(R.id.spinnerEmotion);
		spinnerStress = (Spinner) findViewById(R.id.spinnerStress);
		
		List<Integer> list10 = new ArrayList<Integer>();
		for (int i = 0; i <=10; i++) {
			list10.add(i);
		}
		
		List<Integer> listCaffeine = new ArrayList<Integer>();
		for (int i = 0; i <=30; i++) {
			listCaffeine.add(i);
		}
		
		List<Integer> list24h = new ArrayList<Integer>();
		for (int i = 0; i <=24; i++) {
			list24h.add(i);
		}
		
		List<String> listEmotion = new ArrayList<String>();
		listEmotion.add("Excited");
		listEmotion.add("Happy");
		listEmotion.add("Neutral");
		listEmotion.add("Sad");
		listEmotion.add("Depressed");
		listEmotion.add("Angry");
		
		
		
		ArrayAdapter<Integer> dataAdapterPain = new ArrayAdapter<Integer>(this,
			android.R.layout.simple_spinner_item, list10);
		dataAdapterPain.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spinnerPain.setAdapter(dataAdapterPain);
		
		ArrayAdapter<Integer> dataAdapterCaffeine = new ArrayAdapter<Integer>(this,
				android.R.layout.simple_spinner_item, listCaffeine);
		dataAdapterCaffeine.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spinnerCaffeine.setAdapter(dataAdapterCaffeine);
		
		ArrayAdapter<Integer> dataAdapterSleep = new ArrayAdapter<Integer>(this,
				android.R.layout.simple_spinner_item, list24h);
		dataAdapterCaffeine.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spinnerSleep.setAdapter(dataAdapterSleep);
		
		ArrayAdapter<Integer> dataAdapterActivity = new ArrayAdapter<Integer>(this,
				android.R.layout.simple_spinner_item, list24h);
		dataAdapterCaffeine.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spinnerActivity.setAdapter(dataAdapterActivity);
		
		ArrayAdapter<String> dataAdapterEmotion = new ArrayAdapter<String>(this,
				android.R.layout.simple_spinner_item, listEmotion);
		dataAdapterCaffeine.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
		spinnerEmotion.setAdapter(dataAdapterEmotion);
		
		ArrayAdapter<Integer> dataAdapterStress = new ArrayAdapter<Integer>(this,
				android.R.layout.simple_spinner_item, list10);
			dataAdapterPain.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
			spinnerStress.setAdapter(dataAdapterStress);
		
		
	}
	

	private void addListenerOnSubmit() {
		// TODO Auto-generated method stub
		spinnerPain = (Spinner) findViewById(R.id.spinnerPain);
		spinnerCaffeine = (Spinner) findViewById(R.id.spinnerCaffeine);
		spinnerSleep = (Spinner) findViewById(R.id.spinnerSleep);
		spinnerActivity = (Spinner) findViewById(R.id.spinnerActivity);
		spinnerEmotion = (Spinner) findViewById(R.id.spinnerEmotion);
		spinnerStress = (Spinner) findViewById(R.id.spinnerStress);
		btnSubmit = (Button) findViewById(R.id.buttonSubmit);
		btnSubmit.setOnClickListener(new OnClickListener() {
		public void onClick(View v) {
			
			Toast.makeText(LogActivity.this,"Pain: " + spinnerPain.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
			Toast.makeText(LogActivity.this,"Caffeine: " + spinnerCaffeine.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
			Toast.makeText(LogActivity.this,"Sleep: " + spinnerSleep.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
			Toast.makeText(LogActivity.this,"Activity: " + spinnerActivity.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
			Toast.makeText(LogActivity.this,"Emotion: " + spinnerEmotion.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
			Toast.makeText(LogActivity.this,"Stress: " + spinnerStress.getSelectedItem().toString(),Toast.LENGTH_SHORT).show();
		}
		});
	}
}



