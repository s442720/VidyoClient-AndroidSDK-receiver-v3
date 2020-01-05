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

    FirebaseAuth auth;
    FirebaseUser firebaseUser;
    DatabaseReference reference;
    String token;
    String path;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_starting);

        String txt_email = "g@gmail.com";
        String txt_password = "123456";
        auth = FirebaseAuth.getInstance();

        login(txt_email, txt_password);
        firebaseUser = auth.getCurrentUser();
        path = "Call_" + firebaseUser.getUid();

        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            String message = extras.getString("message");
            Toast.makeText(StartingActivity.this, message, Toast.LENGTH_SHORT).show();
        }

        reference = FirebaseDatabase.getInstance().getReference(path);

        reference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(DataSnapshot dataSnapshot) {

                for (DataSnapshot snapshot: dataSnapshot.getChildren()) {
                    Call call = snapshot.getValue(Call.class);
                    FirebaseUser firebaseUser = auth.getCurrentUser();
                    if (call.getConnected() == 0 && call.getReceiver().equals(firebaseUser.getUid())) {
                        token = call.getToken();

                        AlertDialog.Builder alert = new AlertDialog.Builder(StartingActivity.this);
                        alert.setCancelable(false);
                        alert.setTitle("You have a call from admin...");
                        // alert.setMessage("Message");

                        // pick up the call from caller
                        alert.setPositiveButton("Pick up", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int whichButton) {
                                Intent intent = new Intent(getBaseContext(), MainActivity.class);
                                intent.putExtra("token", token);
                                intent.putExtra("path", path);
                                startActivity(intent);
                            }
                        });
                        // if choose cancel, update the Firebase and the call will end on caller's side
                        alert.setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int whichButton) {
                                reference = FirebaseDatabase.getInstance().getReference(path).child("call").child("connected");
                                int newState = 2;
                                reference.setValue(newState).addOnCompleteListener(new OnCompleteListener<Void>() {
                                    @Override
                                    public void onComplete(@NonNull Task<Void> task) {
                                        if (task.isSuccessful()) {
                                        }
                                    }
                                });
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

    public void login(String txt_email, String txt_password) {
        auth.signInWithEmailAndPassword(txt_email, txt_password)
                .addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()) {
//                            Toast.makeText(StartingActivity.this, "Login successful", Toast.LENGTH_SHORT).show();
                        }
                        else {
//                            Toast.makeText(StartingActivity.this, "Login failed", Toast.LENGTH_SHORT).show();
                        }
                    }
                });
    }

    // disable the back button
    @Override
    public void onBackPressed() {
    // do nothing
    }
}
