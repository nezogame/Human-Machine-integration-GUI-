package MyPackage;

import java.util.Objects;

public class   ScheduledTraining {

    private String training;
    private String person;
    private String date;
    private String startTime;
    private String endTime;

    public ScheduledTraining(String training, String person, String date, String startTime, String endTime) {
        this.training = training;
        this.person = person;
        this.date = date;
        this.startTime = startTime;
        this.endTime = endTime;
    }

    public String getTraining() {
        return training;
    }

    public void setTraining(String training) {
        this.training = training;
    }

    public String getPerson() {
        return person;
    }

    public void setPerson(String person) {
        this.person = person;
    }

    public String getStartTime() {
        return startTime;
    }

    public void setStartTime(String startTime) {
        this.startTime = startTime;
    }

    public String getEndTime() {
        return endTime;
    }

    public void setEndTime(String endTime) {
        this.endTime = endTime;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        ScheduledTraining that = (ScheduledTraining) o;
        return training.equals(that.training) && person.equals(that.person) && date.equals(that.date)
                && startTime.equals(that.startTime) && endTime.equals(that.endTime);
    }

    @Override
    public int hashCode() {
        return Objects.hash(training, person, date, startTime, endTime);
    }

    @Override
    public String toString() {
        return "ScheduledTraining{" +
                "training='" + training + '\'' +
                ", person='" + person + '\'' +
                ", date='" + date + '\'' +
                ", startTime='" + startTime + '\'' +
                ", endTime='" + endTime + '\'' +
                '}';
    }
}
