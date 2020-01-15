package com.vidyo.vidyoconnector;

public class Call {
    private String caller;
    private String receiver;
    private String token;
    private int status;

    public Call() {

    }
    public Call(String caller, String receiver, String token, int status) {
        this.caller = caller;
        this.receiver = receiver;
        this.token = token;
        this.status = status;
    }

    public String getCaller() {
        return caller;
    }

    public void setCaller(String caller) {
        this.caller = caller;
    }

    public String getReceiver() {
        return receiver;
    }

    public void setReceiver(String receiver) {
        this.receiver = receiver;
    }

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }
}
