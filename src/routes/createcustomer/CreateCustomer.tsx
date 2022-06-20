import React from 'react'
import './CreateCustomer.css'


function CreateCustomer() {
    return (
        <form className='createcustomer-container'>
            <div className="form-group col-md-4 ">
                <label htmlFor="inputName">Name</label>
                <div>
                <input type="text" className="form-control" id="inputAddress" placeholder="John Doe" />
                </div>
                <label htmlFor="inputEmail">Email</label>
                <div>
                <input type="text" className="form-control" id="inputEmail" placeholder="johndoe@ymail.com" />
                </div>
            </div>
            <div className="form-group col-md-4">
                <label htmlFor="inputAddress">Address</label>
                <input type="text" className="form-control" id="inputAddress" placeholder="1234 Main St" />
            </div>

            <div className="form-group col-md-4">
                <label htmlFor="inputCity">City</label>
                <input type="text" className="form-control" id="inputCity" />
            </div>
            <div className="form-group col-md-4">
                <label htmlFor="inputState">State</label>
                <select id="inputState" className="form-control">
                    <option selected>Choose...</option>
                    <option value="AL">Alabama</option>
                    <option value="AK">Alaska</option>
                    <option value="AZ">Arizona</option>
                    <option value="AR">Arkansas</option>
                    <option value="CA">California</option>
                    <option value="CO">Colorado</option>
                    <option value="CT">Connecticut</option>
                    <option value="DE">Delaware</option>
                    <option value="DC">District Of Columbia</option>
                    <option value="FL">Florida</option>
                    <option value="GA">Georgia</option>
                    <option value="HI">Hawaii</option>
                    <option value="ID">Idaho</option>
                    <option value="IL">Illinois</option>
                    <option value="IN">Indiana</option>
                    <option value="IA">Iowa</option>
                    <option value="KS">Kansas</option>
                    <option value="KY">Kentucky</option>
                    <option value="LA">Louisiana</option>
                    <option value="ME">Maine</option>
                    <option value="MD">Maryland</option>
                    <option value="MA">Massachusetts</option>
                    <option value="MI">Michigan</option>
                    <option value="MN">Minnesota</option>
                    <option value="MS">Mississippi</option>
                    <option value="MO">Missouri</option>
                    <option value="MT">Montana</option>
                    <option value="NE">Nebraska</option>
                    <option value="NV">Nevada</option>
                    <option value="NH">New Hampshire</option>
                    <option value="NJ">New Jersey</option>
                    <option value="NM">New Mexico</option>
                    <option value="NY">New York</option>
                    <option value="NC">North Carolina</option>
                    <option value="ND">North Dakota</option>
                    <option value="OH">Ohio</option>
                    <option value="OK">Oklahoma</option>
                    <option value="OR">Oregon</option>
                    <option value="PA">Pennsylvania</option>
                    <option value="RI">Rhode Island</option>
                    <option value="SC">South Carolina</option>
                    <option value="SD">South Dakota</option>
                    <option value="TN">Tennessee</option>
                    <option value="TX">Texas</option>
                    <option value="UT">Utah</option>
                    <option value="VT">Vermont</option>
                    <option value="VA">Virginia</option>
                    <option value="WA">Washington</option>
                    <option value="WV">West Virginia</option>
                    <option value="WI">Wisconsin</option>
                    <option value="WY">Wyoming</option>
                </select>
            </div>
            <div className="form-group col-md-4">
                <label htmlFor="inputZip">Zip</label>
                <input type="text" className="form-control" id="inputZip" />
            </div>


            <div className="form-group col-md-4">
                <label htmlFor="inputCardNumber">Card Number</label>
                <input type="text" className="form-control" id="inputCardNumber" aria-describedby="emailHelp" placeholder="" />
            </div>
            <div className="form-group col-md-4">
                <label htmlFor="inputPIN">PIN</label>
                <input type="password" className="form-control" id="inputPIN" placeholder="" />
            </div>
            <br></br>

            <div className="form-group">
                <div className="form-check">
                    <input className="form-check-input" type="checkbox" id="gridCheck" />
                    <label className="form-check-label" htmlFor="gridCheck">
                        Checking
                    </label>
                </div>
                <div className="form-check">
                    <input className="form-check-input" type="checkbox" id="gridCheck" />
                    <label className="form-check-label" htmlFor="gridCheck">
                        Savings
                    </label>
                </div>
                <div className="form-check">
                    <input className="form-check-input" type="checkbox" id="gridCheck" />
                    <label className="form-check-label" htmlFor="gridCheck">
                        Money
                    </label>
                </div>
            </div>
            <br></br>
            <button type="submit" className="btn btn-primary">Create Account</button>
        </form>
    )
}

export default CreateCustomer