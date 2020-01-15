package com.vidyo.vidyoconnector;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class StartingActivity extends AppCompatActivity {

    DatabaseReference reference;
    String path;
    String phone = "695556329";
    int status;
    String token;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_starting);

        // check whether there are parameters from previous activity
        Bundle extras = getIntent().getExtras();
        // If yes, show the message
        if (extras != null) {
            String message = extras.getString("message");
            Toast.makeText(StartingActivity.this, message, Toast.LENGTH_SHORT).show();
        }

        path = "Call_" + phone;
        reference = FirebaseDatabase.getInstance().getReference(path);

        reference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(DataSnapshot dataSnapshot) {

                if (dataSnapshot.hasChild("call")) {
                    if (dataSnapshot.child("call").hasChild("token")) {
                        // get status from database
//                    StartingActivity.this.status = dataSnapshot.child("call").child("status").getValue(Integer.class);
                        // get token from database
                        StartingActivity.this.token = dataSnapshot.child("call").child("token").getValue(String.class);

                        // create an alert
                        AlertDialog.Builder alert = new AlertDialog.Builder(StartingActivity.this);
                        alert.setCancelable(false);
                        alert.setTitle("You have a call from client...");

                        // pick up the call from caller
                        alert.setPositiveButton("Pick up", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int whichButton) {
                                Intent intent = new Intent(getBaseContext(), MainActivity.class);
                                // pass two variables to next activity
                                intent.putExtra("token", token);
                                intent.putExtra("path", path);
                                startActivity(intent);
                            }
                        });
                        // if choose cancel, update the Firebase and the call will end on caller's side
                        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int whichButton) {
                                reference = FirebaseDatabase.getInstance().getReference(path).child("call").child("status");
                                int newState = 2;

                                // update the status to 2
                                reference.setValue(newState);
                                Intent intent = new Intent(getBaseContext(), StartingActivity.class);
                                startActivity(intent);
                            }
                        });
                        alert.show();
                    }

                }

            }
            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });
    }

    // disable the back button
    @Override
    public void onBackPressed() {
    // do nothing
    }
}
